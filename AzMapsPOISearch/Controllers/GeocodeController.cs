using AzMapsPOISearch.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class GeocodeController : ControllerBase
     {
          private readonly IAddressGeocoder gcSvc;
          public GeocodeController(IAddressGeocoder _gcSvc)
          {
               gcSvc = _gcSvc;
          }

          [HttpGet]
          [Route("gcinputaddr")]
          public async Task<ActionResult> GeocodeInputAddresses()
          {
               try
               {
                    var addresses = await gcSvc.GetInputAddr();

                    foreach (var addr in addresses)
                    {
                         string query = $"{addr.CustomerAddress}, {addr.CustomerCity}, {addr.State} {addr.Zip}";
                         var gcRes = await gcSvc.GeocodeAddress(query);

                         if (gcRes == null)
                         {
                              continue;
                         }

                         addr.Lat = gcRes.Position.Lat;
                         addr.Lon = gcRes.Position.Lon;
                         addr.docType = "input";

                         var pois = await gcSvc.FuzzySearch(addr);
                         addr.PoiResults = pois.Results;

                         gcSvc.ReplaceAddr(addr);
                    }

                    return Ok();

               }
               catch (Exception)
               {

                    throw;
               }
          }

          [HttpGet]
          [Route("getinput")]
          public async Task<ActionResult> GetInputAddresses()
          {
               var res = await gcSvc.GetInputAddr();

               return Ok(res);
          }

     }
}
