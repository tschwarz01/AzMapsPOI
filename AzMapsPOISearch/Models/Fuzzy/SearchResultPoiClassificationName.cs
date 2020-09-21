using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models.Fuzzy
{
    public class SearchResultPoiClassificationName
    {
          [JsonPropertyName("nameLocale")]
          public string NameLocale { get; set; }

          [JsonPropertyName("name")]
          public string Name { get; set; }
     }
}
