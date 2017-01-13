using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "message_insert_post")]
    public class MessageInsertPost : IApiResult
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "subject")]
        public string Subject { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }
}