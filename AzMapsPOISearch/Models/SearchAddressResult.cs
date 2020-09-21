using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models
{
     public class SearchAddressResult
     {
          [JsonPropertyName("type")]
          public string Type { get; set; }

          [JsonPropertyName("id")]
          public string Id { get; set; }

          [JsonPropertyName("score")]
          public double Score { get; set; }

          [JsonPropertyName("address")]
          public SearchResultAddress Address { get; set; }

          [JsonPropertyName("position")]
          public Position Position { get; set; }

          [JsonPropertyName("viewport")]
          public Viewport Viewport { get; set; }

          [JsonPropertyName("entryPoints")]
          public List<EntryPoint> EntryPoints { get; set; }
     }
}
