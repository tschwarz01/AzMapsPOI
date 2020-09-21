using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models
{
     public class SearchAddressResponse
     {
          [JsonPropertyName("results")]
          public List<SearchAddressResult> Results { get; set; }

          [JsonPropertyName("summary")]
          public SearchAddressSummary Summary { get; set; }
     }
}
