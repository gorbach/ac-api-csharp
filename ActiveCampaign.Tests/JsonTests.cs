using System.Text;
using ActiveCampaign.Helpers;
using ActiveCampaign.Tests.Resources;
using Xunit;

namespace ActiveCampaign.Tests
{
    public class JsonTests
    {
        public JsonTests()
        {
        }

        [Fact]
        public void parse_address_response()
        {
            var json = Encoding.UTF8.GetString(Files.address_list);
            var result = AddressResponseParser.Parse(json);
            Assert.Equal(result.Addresses.Count, 2);
        }
    }
}