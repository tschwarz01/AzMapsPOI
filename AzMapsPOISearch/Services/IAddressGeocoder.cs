using AzMapsPOISearch.Models;
using AzMapsPOISearch.Models.Fuzzy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Services
{
     public interface IAddressGeocoder
     {
          Task<SearchAddressResult> GeocodeAddress(string addrString);
          Task<List<InputAddr>> GetInputAddr();
          void ReplaceAddr(InputAddr addr);
          Task<SearchFuzzyResponse> FuzzySearch(InputAddr addr);
     }
}
