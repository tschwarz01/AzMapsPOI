using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models.Fuzzy
{
    public class SearchResultPoi
    {
          [JsonPropertyName("name")]
          public string Name { get; set; }

          [JsonPropertyName("categorySet")]
          public List<SearchResultPoiCategorySet> CategorySet { get; set; }

          [JsonPropertyName("categories")]
          public List<string> Categories { get; set; }

          [JsonPropertyName("classifications")]
          public List<SearchResultPoiClassification> Classifications { get; set; }

          [JsonPropertyName("phone")]
          public string Phone { get; set; }
     }
}
