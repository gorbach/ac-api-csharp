using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "subscriber_update_post")]
    public class SubscriberUpdatePost : IApiResult
    {
        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }
        
    [XmlRoot(ElementName = "bounces")]
    public class Bounces
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "userid")]
        public string Userid { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "email")]
        public string Email { get; set; }
        [XmlElement(ElementName = "host")]
        public string Host { get; set; }
        [XmlElement(ElementName = "port")]
        public string Port { get; set; }
        [XmlElement(ElementName = "user")]
        public string User { get; set; }
        [XmlElement(ElementName = "pass")]
        public string Pass { get; set; }
        [XmlElement(ElementName = "method")]
        public string Method { get; set; }
        [XmlElement(ElementName = "limit_hard")]
        public string Limit_hard { get; set; }
        [XmlElement(ElementName = "limit_soft")]
        public string Limit_soft { get; set; }
        [XmlElement(ElementName = "emails_per_batch")]
        public string Emails_per_batch { get; set; }
    }
}