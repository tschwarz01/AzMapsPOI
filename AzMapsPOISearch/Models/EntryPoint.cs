using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models
{
     public class EntryPoint
     {
          [JsonPropertyName("type")]
          public string Type { get; set; }

          [JsonPropertyName("position")]
          public Position Position { get; set; }
     }
}
