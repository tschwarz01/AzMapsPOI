using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzMapsPOISearch
{
     public sealed class AzureMapsConfiguration
     {
          public string ApiKey { get; set; }
          public string AddressBaseUrl { get; set; }
          public string ReverseBaseUrl { get; set; }
          public string PolygonBaseUrl { get; set; }
          public string FuzzyBaseUrl { get; set; }
     }
}
