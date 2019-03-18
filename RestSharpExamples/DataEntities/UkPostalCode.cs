using Newtonsoft.Json;

namespace RestSharpExamples.DataEntities
{
    public class UkPostalCode
    {
        [JsonProperty("adminCode1")]
        public string AdminCode1 { get; set; }
        [JsonProperty("adminCode2")]
        public string AdminCode2 { get; set; }
        [JsonProperty("adminCode3")]
        public string AdminCode3 { get; set; }
        [JsonProperty("adminName1")]
        public string AdminName1 { get; set; }
        [JsonProperty("adminName2")]
        public string AdminName2 { get; set; }
        [JsonProperty("adminName3")]
        public string AdminName3 { get; set; }
        [JsonProperty("lng")]
        public double Longitude { get; set; }
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("placeName")]
        public string PlaceName { get; set; }

        /*
            "adminCode2": "",
            "adminCode3": "E06000049",
            "adminName3": "Cheshire East (B)",
            "adminCode1": "ENG",
            "adminName2": "Cheshire",
            "lng": -2.326011746739711,
            "countryCode": "GB",
            "postalCode": "WA16 7GB",
            "adminName1": "England",
            "placeName": "Mobberley",
            "lat": 53.31390491673897
         */
    }
}
