using System.Collections.Generic;
using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "message_select_list")]
    public class MessageSelectList : IApiResult
    {
        [XmlElement(ElementName = "row")]
        public List<Message> Messages { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }

    [XmlRoot(ElementName = "lists")]
    public class MsgLists
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "stringid")]
        public string Stringid { get; set; }
        [XmlElement(ElementName = "userid")]
        public string Userid { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "cdate")]
        public string Cdate { get; set; }
        [XmlElement(ElementName = "p_use_tracking")]
        public string P_use_tracking { get; set; }
        [XmlElement(ElementName = "p_use_analytics_read")]
        public string P_use_analytics_read { get; set; }
        [XmlElement(ElementName = "p_use_analytics_link")]
        public string P_use_analytics_link { get; set; }
        [XmlElement(ElementName = "p_use_twitter")]
        public string P_use_twitter { get; set; }
        [XmlElement(ElementName = "p_use_facebook")]
        public string P_use_facebook { get; set; }
        [XmlElement(ElementName = "p_embed_image")]
        public string P_embed_image { get; set; }
        [XmlElement(ElementName = "p_use_captcha")]
        public string P_use_captcha { get; set; }
        [XmlElement(ElementName = "send_last_broadcast")]
        public string Send_last_broadcast { get; set; }
        [XmlElement(ElementName = "private")]
        public string Private { get; set; }
        [XmlElement(ElementName = "analytics_domains")]
        public string Analytics_domains { get; set; }
        [XmlElement(ElementName = "analytics_source")]
        public string Analytics_source { get; set; }
        [XmlElement(ElementName = "analytics_ua")]
        public string Analytics_ua { get; set; }
        [XmlElement(ElementName = "twitter_token")]
        public string Twitter_token { get; set; }
        [XmlElement(ElementName = "twitter_token_secret")]
        public string Twitter_token_secret { get; set; }
        [XmlElement(ElementName = "facebook_session")]
        public string Facebook_session { get; set; }
        [XmlElement(ElementName = "carboncopy")]
        public string Carboncopy { get; set; }
        [XmlElement(ElementName = "subscription_notify")]
        public string Subscription_notify { get; set; }
        [XmlElement(ElementName = "unsubscription_notify")]
        public string Unsubscription_notify { get; set; }
        [XmlElement(ElementName = "require_name")]
        public string Require_name { get; set; }
        [XmlElement(ElementName = "get_unsubscribe_reason")]
        public string Get_unsubscribe_reason { get; set; }
        [XmlElement(ElementName = "to_name")]
        public string To_name { get; set; }
        [XmlElement(ElementName = "optinoptout")]
        public string Optinoptout { get; set; }
        [XmlElement(ElementName = "sender_name")]
        public string Sender_name { get; set; }
        [XmlElement(ElementName = "sender_addr1")]
        public string Sender_addr1 { get; set; }
        [XmlElement(ElementName = "sender_addr2")]
        public string Sender_addr2 { get; set; }
        [XmlElement(ElementName = "sender_city")]
        public string Sender_city { get; set; }
        [XmlElement(ElementName = "sender_state")]
        public string Sender_state { get; set; }
        [XmlElement(ElementName = "sender_zip")]
        public string Sender_zip { get; set; }
        [XmlElement(ElementName = "sender_country")]
        public string Sender_country { get; set; }
        [XmlElement(ElementName = "sender_phone")]
        public string Sender_phone { get; set; }
        [XmlElement(ElementName = "sender_url")]
        public string Sender_url { get; set; }
        [XmlElement(ElementName = "sender_reminder")]
        public string Sender_reminder { get; set; }
        [XmlElement(ElementName = "fulladdress")]
        public string Fulladdress { get; set; }
        [XmlElement(ElementName = "optinmessageid")]
        public string Optinmessageid { get; set; }
        [XmlElement(ElementName = "optoutconf")]
        public string Optoutconf { get; set; }
        [XmlElement(ElementName = "deletestamp")]
        public string Deletestamp { get; set; }
    }

    [XmlRoot(ElementName = "fields")]
    public class Fields
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
        [XmlElement(ElementName = "tag")]
        public string Tag { get; set; }
        [XmlElement(ElementName = "options")]
        public List<Options> Options { get; set; }
        [XmlElement(ElementName = "selected")]
        public string Selected { get; set; }
    }

    [XmlRoot(ElementName = "personalizations")]
    public class Personalizations
    {
        [XmlElement(ElementName = "html")]
        public string Html { get; set; }
        [XmlElement(ElementName = "text")]
        public string Text { get; set; }
    }

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