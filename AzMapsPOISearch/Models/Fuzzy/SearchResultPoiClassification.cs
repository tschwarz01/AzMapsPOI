using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models.Fuzzy
{
    public class SearchResultPoiClassification
    {
          [JsonPropertyName("code")]
          public string Code { get; set; }

          [JsonPropertyName("names")]
          public List<SearchResultPoiClassificationName> Names { get; set; }
     }
}
