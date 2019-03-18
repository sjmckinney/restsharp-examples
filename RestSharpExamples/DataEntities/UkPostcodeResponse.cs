using Newtonsoft.Json;
using System.Collections.Generic;

namespace RestSharpExamples.DataEntities
{
    public class UkPostcodeResponse
    {
        [JsonProperty("postCodes")]
        public List<UkPostalCode> PostalCodes { get; set; }
    }
}
