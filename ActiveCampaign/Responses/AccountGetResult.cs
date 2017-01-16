using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "account_get")]
    public class AccountGetResult : IApiResult
    {
        [XmlElement(ElementName = "account")]
        public string Account { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "fname")]
        public string Fname { get; set; }

        [XmlElement(ElementName = "lname")]
        public string Lname { get; set; }

        [XmlElement(ElementName = "cname")]
        public string Cname { get; set; }

        [XmlElement(ElementName = "subscriber_limit")]
        public string Subscriber_limit { get; set; }

        [XmlElement(ElementName = "subscriber_total")]
        public string Subscriber_total { get; set; }

        [XmlElement(ElementName = "status")]
        public string Status { get; set; }

        [XmlElement(ElementName = "branding")]
        public string Branding { get; set; }

        [XmlElement(ElementName = "trial")]
        public string Trial { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string Result_message { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string Result_output { get; set; }
    }
}