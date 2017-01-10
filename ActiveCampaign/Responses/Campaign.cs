using System.Collections.Generic;
using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "links")]
    public class Links
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
        [XmlElement(ElementName = "count")]
        public string Count { get; set; }
        [XmlElement(ElementName = "format")]
        public string Format { get; set; }
        [XmlElement(ElementName = "messageid")]
        public string Messageid { get; set; }
        [XmlElement(ElementName = "actions")]
        public string Actions { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
    }

    [XmlRoot(ElementName = "messages")]
    public class Messages
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
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
        [XmlElement(ElementName = "files")]
        public string Files { get; set; }
        [XmlElement(ElementName = "filescnt")]
        public string Filescnt { get; set; }
        [XmlElement(ElementName = "activerss_show")]
        public string Activerss_show { get; set; }
        [XmlElement(ElementName = "htmlfetchurl")]
        public string Htmlfetchurl { get; set; }
        [XmlElement(ElementName = "textfetchurl")]
        public string Textfetchurl { get; set; }
        [XmlElement(ElementName = "links")]
        public List<Links> Links { get; set; }
        [XmlElement(ElementName = "percentage")]
        public string Percentage { get; set; }
        [XmlElement(ElementName = "sourcesize")]
        public string Sourcesize { get; set; }
        [XmlElement(ElementName = "spamcheck_score")]
        public string Spamcheck_score { get; set; }
        [XmlElement(ElementName = "spamcheck_max")]
        public string Spamcheck_max { get; set; }
        [XmlElement(ElementName = "lists")]
        public Lists Lists { get; set; }
        [XmlElement(ElementName = "listslist")]
        public string Listslist { get; set; }
        [XmlElement(ElementName = "images")]
        public Images Images { get; set; }
    }

    [XmlRoot(ElementName = "row")]
    public class CampaignRow
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "userid")]
        public string Userid { get; set; }
        [XmlElement(ElementName = "segmentid")]
        public string Segmentid { get; set; }
        [XmlElement(ElementName = "seriesid")]
        public string Seriesid { get; set; }
        [XmlElement(ElementName = "formid")]
        public string Formid { get; set; }
        [XmlElement(ElementName = "basetemplateid")]
        public string Basetemplateid { get; set; }
        [XmlElement(ElementName = "basemessageid")]
        public string Basemessageid { get; set; }
        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "cdate")]
        public string Cdate { get; set; }
        [XmlElement(ElementName = "mdate")]
        public string Mdate { get; set; }
        [XmlElement(ElementName = "sdate")]
        public string Sdate { get; set; }
        [XmlElement(ElementName = "ldate")]
        public string Ldate { get; set; }
        [XmlElement(ElementName = "send_amt")]
        public string Send_amt { get; set; }
        [XmlElement(ElementName = "total_amt")]
        public string Total_amt { get; set; }
        [XmlElement(ElementName = "opens")]
        public string Opens { get; set; }
        [XmlElement(ElementName = "uniqueopens")]
        public string Uniqueopens { get; set; }
        [XmlElement(ElementName = "linkclicks")]
        public string Linkclicks { get; set; }
        [XmlElement(ElementName = "uniquelinkclicks")]
        public string Uniquelinkclicks { get; set; }
        [XmlElement(ElementName = "subscriberclicks")]
        public string Subscriberclicks { get; set; }
        [XmlElement(ElementName = "forwards")]
        public string Forwards { get; set; }
        [XmlElement(ElementName = "uniqueforwards")]
        public string Uniqueforwards { get; set; }
        [XmlElement(ElementName = "hardbounces")]
        public string Hardbounces { get; set; }
        [XmlElement(ElementName = "softbounces")]
        public string Softbounces { get; set; }
        [XmlElement(ElementName = "unsubscribes")]
        public string Unsubscribes { get; set; }
        [XmlElement(ElementName = "unsubreasons")]
        public string Unsubreasons { get; set; }
        [XmlElement(ElementName = "updates")]
        public string Updates { get; set; }
        [XmlElement(ElementName = "socialshares")]
        public string Socialshares { get; set; }
        [XmlElement(ElementName = "replies")]
        public string Replies { get; set; }
        [XmlElement(ElementName = "uniquereplies")]
        public string Uniquereplies { get; set; }
        [XmlElement(ElementName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "tracklinks")]
        public string Tracklinks { get; set; }
        [XmlElement(ElementName = "tracklinksanalytics")]
        public string Tracklinksanalytics { get; set; }
        [XmlElement(ElementName = "trackreads")]
        public string Trackreads { get; set; }
        [XmlElement(ElementName = "trackreadsanalytics")]
        public string Trackreadsanalytics { get; set; }
        [XmlElement(ElementName = "analytics_campaign_name")]
        public string Analytics_campaign_name { get; set; }
        [XmlElement(ElementName = "tweet")]
        public string Tweet { get; set; }
        [XmlElement(ElementName = "facebook")]
        public string Facebook { get; set; }
        [XmlElement(ElementName = "survey")]
        public string Survey { get; set; }
        [XmlElement(ElementName = "recurring")]
        public string Recurring { get; set; }
        [XmlElement(ElementName = "split_type")]
        public string Split_type { get; set; }
        [XmlElement(ElementName = "split_offset")]
        public string Split_offset { get; set; }
        [XmlElement(ElementName = "split_offset_type")]
        public string Split_offset_type { get; set; }
        [XmlElement(ElementName = "split_winner_messageid")]
        public string Split_winner_messageid { get; set; }
        [XmlElement(ElementName = "split_winner_awaiting")]
        public string Split_winner_awaiting { get; set; }
        [XmlElement(ElementName = "responder_offset")]
        public string Responder_offset { get; set; }
        [XmlElement(ElementName = "reminder_field")]
        public string Reminder_field { get; set; }
        [XmlElement(ElementName = "reminder_format")]
        public string Reminder_format { get; set; }
        [XmlElement(ElementName = "reminder_type")]
        public string Reminder_type { get; set; }
        [XmlElement(ElementName = "reminder_offset")]
        public string Reminder_offset { get; set; }
        [XmlElement(ElementName = "reminder_offset_type")]
        public string Reminder_offset_type { get; set; }
        [XmlElement(ElementName = "reminder_offset_sign")]
        public string Reminder_offset_sign { get; set; }
        [XmlElement(ElementName = "activerss_interval")]
        public string Activerss_interval { get; set; }
        [XmlElement(ElementName = "activerss_url")]
        public string Activerss_url { get; set; }
        [XmlElement(ElementName = "activerss_items")]
        public string Activerss_items { get; set; }
        [XmlElement(ElementName = "laststep")]
        public string Laststep { get; set; }
        [XmlElement(ElementName = "schedule")]
        public string Schedule { get; set; }
        [XmlElement(ElementName = "scheduleddate")]
        public string Scheduleddate { get; set; }
        [XmlElement(ElementName = "replysys")]
        public string Replysys { get; set; }
        [XmlElement(ElementName = "listslist")]
        public string Listslist { get; set; }
        [XmlElement(ElementName = "messages")]
        public Messages Messages { get; set; }
        [XmlElement(ElementName = "messageslist")]
        public string Messageslist { get; set; }
        [XmlElement(ElementName = "formname")]
        public string Formname { get; set; }
        [XmlElement(ElementName = "lists")]
        public Lists Lists { get; set; }
        [XmlElement(ElementName = "seriesname")]
        public string Seriesname { get; set; }
    }

    [XmlRoot(ElementName = "lists")]
    public class Lists
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "campaignid")]
        public string Campaignid { get; set; }
        [XmlElement(ElementName = "listid")]
        public string Listid { get; set; }
        [XmlElement(ElementName = "userid")]
        public string Userid { get; set; }
        [XmlElement(ElementName = "list_amt")]
        public string List_amt { get; set; }
        [XmlElement(ElementName = "stringid")]
        public string Stringid { get; set; }
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
        [XmlElement(ElementName = "relid")]
        public string Relid { get; set; }
    }

    [XmlRoot(ElementName = "images")]
    public class Images
    {
        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
        [XmlElement(ElementName = "hash")]
        public string Hash { get; set; }
    }

    [XmlRoot(ElementName = "campaign_select_list")]
    public class CampaignSelectListResult : IApiResult
    {
        [XmlElement(ElementName = "row")]
        public List<CampaignRow> Campaigns { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }
}