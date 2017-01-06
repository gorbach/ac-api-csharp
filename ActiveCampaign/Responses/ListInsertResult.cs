using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "list_insert_post")]
    public class ListInsertResult : IApiResult
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string Result_message { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string Result_output { get; set; }
    }
}