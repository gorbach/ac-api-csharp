using System.Collections.Generic;
using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "list_select_list")]
    public class ListSelectList
    {
        [XmlElement(ElementName = "row")]
        public List<ListRow> Lists { get; set; }
        [XmlElement(ElementName = "result_code")]
        public string Result_code { get; set; }
        [XmlElement(ElementName = "result_message")]
        public string Result_message { get; set; }
        [XmlElement(ElementName = "result_output")]
        public string Result_output { get; set; }
    }
}