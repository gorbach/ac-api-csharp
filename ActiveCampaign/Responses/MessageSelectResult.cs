using System.Collections.Generic;
using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "message_select_row")]
    public class MessageSelectResult : IApiResult
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "userid")]
        public string Userid { get; set; }

        [XmlElement(ElementName = "ed_instanceid")]
        public string Ed_instanceid { get; set; }

        [XmlElement(ElementName = "ed_version")]
        public string Ed_version { get; set; }

        [XmlElement(ElementName = "cdate")]
        public string Cdate { get; set; }

        [XmlElement(ElementName = "mdate")]
        public string Mdate { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "fromname")]
        public string Fromname { get; set; }

        [XmlElement(ElementName = "fromemail")]
        public string Fromemail { get; set; }

        [XmlElement(ElementName = "reply2")]
        public string Reply2 { get; set; }

        [XmlElement(ElementName = "priority")]
        public string Priority { get; set; }

        [XmlElement(ElementName = "charset")]
        public string Charset { get; set; }

        [XmlElement(ElementName = "encoding")]
        public string Encoding { get; set; }

        [XmlElement(ElementName = "format")]
        public string Format { get; set; }

        [XmlElement(ElementName = "subject")]
        public string Subject { get; set; }

        [XmlElement(ElementName = "text")]
        public string Text { get; set; }
        [XmlElement(ElementName = "html")]
        public string Html { get; set; }

        [XmlElement(ElementName = "htmlfetch")]
        public string Htmlfetch { get; set; }

        [XmlElement(ElementName = "textfetch")]
        public string Textfetch { get; set; }

        [XmlElement(ElementName = "hidden")]
        public string Hidden { get; set; }

        [XmlElement(ElementName = "preview_mime")]
        public string Preview_mime { get; set; }

        [XmlElement(ElementName = "preview_data")]
        public string Preview_data { get; set; }

        [XmlElement(ElementName = "lists")]
        public List<MsgLists> Lists { get; set; }

        [XmlElement(ElementName = "files")]
        public string Files { get; set; }

        [XmlElement(ElementName = "filescnt")]
        public string Filescnt { get; set; }

        [XmlElement(ElementName = "listslist")]
        public string Listslist { get; set; }

        [XmlElement(ElementName = "fields")]
        public List<Fields> Fields { get; set; }

        [XmlElement(ElementName = "personalizations")]
        public Personalizations Personalizations { get; set; }

        [XmlElement(ElementName = "activerss_show")]
        public string Activerss_show { get; set; }

        [XmlElement(ElementName = "htmlfetchurl")]
        public string Htmlfetchurl { get; set; }

        [XmlElement(ElementName = "textfetchurl")]
        public string Textfetchurl { get; set; }

        [XmlElement(ElementName = "links")]
        public string Links { get; set; }

        [XmlElement(ElementName = "images")]
        public Images Images { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }
}