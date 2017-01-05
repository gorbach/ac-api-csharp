using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "subscriber_insert_post")]
    public class SubscriberInsertResponse : IApiResult
    {
        [XmlElement(ElementName = "subscriber_id")]
        public int SubscriberId { get; set; }

        [XmlElement(ElementName = "sendlast_should")]
        public string SendlastShould { get; set; }

        [XmlElement(ElementName = "sendlast_did")]
        public string SendlastDid { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }
}