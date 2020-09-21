using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models.Fuzzy
{
    public class SearchResultPoiCategorySet
    {
          [JsonPropertyName("id")]
          public int Id { get; set; }
     }
}
