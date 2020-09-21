using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models.Fuzzy
{
    public class SearchFuzzySummary
    {
          [JsonPropertyName("query")]
          public string Query { get; set; }

          [JsonPropertyName("queryType")]
          public string QueryType { get; set; }

          [JsonPropertyName("queryTime")]
          public int QueryTime { get; set; }

          [JsonPropertyName("numResults")]
          public int NumResults { get; set; }

          [JsonPropertyName("offset")]
          public int Offset { get; set; }

          [JsonPropertyName("totalResults")]
          public int TotalResults { get; set; }

          [JsonPropertyName("fuzzyLevel")]
          public int FuzzyLevel { get; set; }

          [JsonPropertyName("geoBias")]
          public Position GeoBias { get; set; }
     }
}
