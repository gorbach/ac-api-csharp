using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "row")]
    public class Message
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "subject")]
        public string Subject { get; set; }

        [XmlElement(ElementName = "files")]
        public string Files { get; set; }

        [XmlElement(ElementName = "filescnt")]
        public string Filescnt { get; set; }
    }
}