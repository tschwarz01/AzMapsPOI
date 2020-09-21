using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AzMapsPOISearch.Models
{
     public class SearchResultAddress
     {
          [JsonPropertyName("buildingNumber")]
          public string BuildingNumber { get; set; }

          [JsonPropertyName("streetNumber")]
          public string StreetNumber { get; set; }

          [JsonPropertyName("street")]
          public string Street { get; set; }

          [JsonPropertyName("streetName")]
          public string StreetName { get; set; }

          [JsonPropertyName("streetNameAndNumber")]
          public string StreetNameAndNumber { get; set; }

          [JsonPropertyName("municipality")]
          public string Municipality { get; set; }

          [JsonPropertyName("municipalitySubdivision")]
          public string MunicipalitySubdivision { get; set; }

          [JsonPropertyName("countrySecondarySubdivision")]
          public string CountrySecondarySubdivision { get; set; }

          [JsonPropertyName("countryTertiarySubdivision")]
          public string CountryTertiarySubdivision { get; set; }

          [JsonPropertyName("countrySubdivision")]
          public string CountrySubdivision { get; set; }

          [JsonPropertyName("countrySubdivisionName")]
          public string CountrySubdivisionName { get; set; }

          [JsonPropertyName("postalCode")]
          public string PostalCode { get; set; }

          [JsonPropertyName("extendedPostalCode")]
          public string ExtendedPostalCode { get; set; }

          [JsonPropertyName("countryCode")]
          public string CountryCode { get; set; }

          [JsonPropertyName("crossStreet")]
          public string CrossStreet { get; set; }

          [JsonPropertyName("country")]
          public string Country { get; set; }

          [JsonPropertyName("countryCodeISO3")]
          public string CountryCodeISO3 { get; set; }

          [JsonPropertyName("freeformAddress")]
          public string FreeformAddress { get; set; }

          [JsonPropertyName("localName")]
          public string LocalName { get; set; }

          [JsonPropertyName("routeNumbers")]
          public int[] RouteNumbers { get; set; }
     }
}
