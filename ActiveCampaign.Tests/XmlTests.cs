using ActiveCampaign.Models;
using ActiveCampaign.Responses;
using Xunit;

namespace ActiveCampaign.Tests
{
    public class XmlTests
    {
        [Fact]
        public void can_deserialize_sync_response()
        {
            var xml = Resources.Files.subs_sync;

            var responze = XmlHelper.Deserialize<SubscriberSyncResponse>(xml);

            Assert.Equal(0, responze.ResultCode);
            Assert.Equal(true, responze.HasError());
            Assert.Equal(@"There was an error processing custom field CompanyName. Try encoding each 'field[]' parameter.", responze.ResultMessage);
        }

        [Fact]
        public void can_deserialize_contact_add_response()
        {
            var xml = Resources.Files.subscriber_insert_post;

            var responze = XmlHelper.Deserialize<SubscriberInsertResponse>(xml);

            Assert.Equal(1, responze.ResultCode);
            Assert.Equal(false, responze.HasError());
            Assert.Equal(154, responze.SubscriberId);
        }


        [Fact]
        public void can_deserialize_contact_update_response()
        {
            var xml = Resources.Files.subscriber_update_post;

            var responze = XmlHelper.Deserialize<SubscriberUpdatePost>(xml);

            Assert.Equal(0, responze.ResultCode);
            Assert.Equal(true, responze.HasError());
        }
    }
}