using System.Collections.Generic;
using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "row")]
    public class Row
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "descript")]
        public string Descript { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "isrequired")]
        public string Isrequired { get; set; }
        [XmlElement(ElementName = "perstag")]
        public string Perstag { get; set; }
        [XmlElement(ElementName = "defval")]
        public string Defval { get; set; }
        [XmlElement(ElementName = "show_in_list")]
        public string Show_in_list { get; set; }
        [XmlElement(ElementName = "rows")]
        public string Rows { get; set; }
        [XmlElement(ElementName = "cols")]
        public string Cols { get; set; }
        [XmlElement(ElementName = "visible")]
        public string Visible { get; set; }
        [XmlElement(ElementName = "service")]
        public string Service { get; set; }
        [XmlElement(ElementName = "ordernum")]
        public string Ordernum { get; set; }
        [XmlElement(ElementName = "relid")]
        public string Relid { get; set; }
        [XmlElement(ElementName = "val")]
        public string Val { get; set; }
        [XmlElement(ElementName = "dataid")]
        public string Dataid { get; set; }
        [XmlElement(ElementName = "element")]
        public string Element { get; set; }
        [XmlElement(ElementName = "options")]
        public List<Options> Options { get; set; }
        [XmlElement(ElementName = "selected")]
        public string Selected { get; set; }
        [XmlElement(ElementName = "tag")]
        public string Tag { get; set; }
        [XmlElement(ElementName = "lists")]
        public List<string> Lists { get; set; }
    }
}