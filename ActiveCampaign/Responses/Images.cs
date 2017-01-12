using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "images")]
    public class Images
    {
        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
        [XmlElement(ElementName = "hash")]
        public string Hash { get; set; }
    }
}