using AzMapsPOISearch.Models;
using AzMapsPOISearch.Models.Fuzzy;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Services
{
     public class AzMapsGeocoder : IAddressGeocoder
     {
          private readonly IConfiguration config;
          private readonly IHttpClientFactory _clientFactory;
          private readonly AzureMapsConfiguration _settings;
          private readonly CosmosClient cosmosClient;
          private readonly Container inContainer;
          private readonly Container gcContainer;

          public AzMapsGeocoder(IConfiguration configuration, IHttpClientFactory clientFactory, CosmosClient CosmosClient)
          {
               config = configuration;
               _settings = new AzureMapsConfiguration();
               config.GetSection("AzureMaps").Bind(_settings);
               _clientFactory = clientFactory;
               cosmosClient = CosmosClient;
               inContainer = cosmosClient.GetContainer("AzureMaps", "<SOURCE ADDRESS COSMOS DB COLLECTION NAME");
               gcContainer = cosmosClient.GetContainer("AzureMaps", "<OUTPUT COLLECTION NAME>");
          }
          public async Task<SearchAddressResult> GeocodeAddress(string addrString)
          {

               string query = addrString ?? throw new ArgumentNullException(nameof(addrString), "Input address cannot be null");

               string myUrl = $"{_settings.AddressBaseUrl}api-version=1.0&subscription-key={_settings.ApiKey}&limit=1&query={query}";

               var client = _clientFactory.CreateClient();
               client.DefaultRequestHeaders.Accept.Clear();
               client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

               var streamTask = client.GetStreamAsync(myUrl);
               var res = await JsonSerializer.DeserializeAsync<SearchAddressResponse>(await streamTask);

               return res.Results.FirstOrDefault();
          }

          public async Task<SearchFuzzyResponse> FuzzySearch(InputAddr addr)
          {
               string query = $"{addr.CustomerAddress} {addr.CustomerCity} {addr.State} {addr.Zip}";

               string myUrl = $"{_settings.FuzzyBaseUrl}api-version=1.0&subscription-key={_settings.ApiKey}&limit=20&lat={addr.Lat}&lon={addr.Lon}&idxSet=POI&radius=200&query={query}";

               var client = _clientFactory.CreateClient();
               client.DefaultRequestHeaders.Accept.Clear();
               client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));

               try
               {

                    var streamTask = client.GetStreamAsync(myUrl);
                    var res = await JsonSerializer.DeserializeAsync<SearchFuzzyResponse>(await streamTask);
                    return res;
               }
               catch (Exception)
               {

                    throw;
               }

          }

          public async Task<List<InputAddr>> GetInputAddr()
          {
               try
               {
                    // UPDATE
                    var queryString = "SELECT * FROM f";
                    var query = this.inContainer.GetItemQueryIterator<InputAddr>(new QueryDefinition(queryString));
                    List<InputAddr> results = new List<InputAddr>();
                    while (query.HasMoreResults)
                    {
                         var response = await query.ReadNextAsync();
                         results.AddRange(response.ToList());
                    }

                    return results;
               }
               catch (Exception)
               {
                    throw;
               }
          }

          public async void ReplaceAddr(InputAddr addr)
          {
               try
               {
                    var res = await this.inContainer.ReplaceItemAsync<InputAddr>(
                         partitionKey: new PartitionKey(addr.docType),
                         id: addr.id,
                         item: addr);

                    //var res = await this.gcContainer.UpsertItemAsync(partitionKey: new PartitionKey(addr.docType), item: addr);

                    InputAddr updated = res.Resource;
               }
               catch (Exception)
               {
                    throw;
               }
          }
     }
}
