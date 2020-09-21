using AzMapsPOISearch.Models.Fuzzy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models
{
    public class InputAddr
    {
          [JsonPropertyName("docType")]
          public string docType { get; set; }

          [JsonPropertyName("businessName")]
          public string BusinessName { get; set; }

          [JsonPropertyName("customerAddress")]
          public string CustomerAddress { get; set; }

          [JsonPropertyName("customerCity")]
          public string CustomerCity { get; set; }

          [JsonPropertyName("state")]
          public string State { get; set; }

          [JsonPropertyName("zip")]
          public string Zip { get; set; }

          [JsonPropertyName("businessCategory")]
          public string BusinessCategory { get; set; }

          [JsonPropertyName("id")]
          public string id { get; set; }

          [JsonPropertyName("lat")]
          public double Lat { get; set; }

          [JsonPropertyName("lon")]
          public double Lon { get; set; }

          [JsonPropertyName("poiResults")]
          public List<SearchFuzzyResult> PoiResults { get; set; }
     }
}
