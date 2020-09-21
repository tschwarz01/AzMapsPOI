using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models
{
     public class Position
     {
          [JsonPropertyName("lat")]
          public double Lat { get; set; }

          [JsonPropertyName("lon")]
          public double Lon { get; set; }
     }
}
