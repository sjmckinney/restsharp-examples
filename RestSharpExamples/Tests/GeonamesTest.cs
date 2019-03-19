using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using RestSharpExamples.DataEntities;

namespace RestSharpExamples.Tests
{
    [TestFixture]
    public class GeonamesTest
    {
        readonly private string geonamesHost = "http://api.geonames.org";
        readonly private string path = "postalCodeSearchJSON?";
        readonly private string username = "smckinney";


        [TestCase]
        public void PostcodeLookupSingleResult()
        {
            // arrange
            var postcode = "WA16 7GB";

            RestClient client = new RestClient(geonamesHost);
            RestRequest request = new RestRequest($"{path}postalcode={postcode}&maxRows=10&username={username}", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            // assert

            UkPostcodeResponse ukPostcodeResponse =
            new JsonDeserializer().
            Deserialize<UkPostcodeResponse>(response);

            Assert.That(ukPostcodeResponse.PostalCodes[0].CountryCode, Is.EqualTo("GB"));
        }

        [TestCase]
        public void PostCodeLookupMultipleResults()
        {
            // arrange
            var postcode = "WA16";

            RestClient client = new RestClient(geonamesHost);
            RestRequest request = new RestRequest($"{path}postalcode={postcode}&maxRows=10&username={username}", Method.GET);

            // act
            IRestResponse response = client.Execute(request);

            //assert

            UkPostcodeResponse ukPostcodeResponse =
            new JsonDeserializer().
            Deserialize<UkPostcodeResponse>(response);

            Assert.That(ukPostcodeResponse.PostalCodes[0].PostalCode, Is.EqualTo("WA16 0AA"));
            Assert.That(ukPostcodeResponse.PostalCodes[1].PostalCode, Is.EqualTo("WA16 0AB"));

            Assert.That(ukPostcodeResponse.PostalCodes[1].Lat, Is.EqualTo(53.303315033592931d));

        }
    }
}
