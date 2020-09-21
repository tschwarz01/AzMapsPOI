using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models.Fuzzy
{
    public class SearchFuzzyResponse
    {
          [JsonPropertyName("summary")]
          public SearchFuzzySummary Summary { get; set; }

          [JsonPropertyName("results")]
          public List<SearchFuzzyResult> Results { get; set; }
     }
}
