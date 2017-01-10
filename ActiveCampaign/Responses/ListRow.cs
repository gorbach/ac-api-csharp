using System.Collections.Generic;
using System.Xml.Serialization;
using ActiveCampaign.Models;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "row")]
    public class ListRow
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

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

        [XmlElement(ElementName = "listid")]
        public string Listid { get; set; }

        [XmlElement(ElementName = "p_admin")]
        public string P_admin { get; set; }

        [XmlElement(ElementName = "p_list_add")]
        public string P_list_add { get; set; }

        [XmlElement(ElementName = "p_list_edit")]
        public string P_list_edit { get; set; }

        [XmlElement(ElementName = "p_list_delete")]
        public string P_list_delete { get; set; }

        [XmlElement(ElementName = "p_list_sync")]
        public string P_list_sync { get; set; }

        [XmlElement(ElementName = "p_list_filter")]
        public string P_list_filter { get; set; }

        [XmlElement(ElementName = "p_message_add")]
        public string P_message_add { get; set; }

        [XmlElement(ElementName = "p_message_edit")]
        public string P_message_edit { get; set; }

        [XmlElement(ElementName = "p_message_delete")]
        public string P_message_delete { get; set; }

        [XmlElement(ElementName = "p_message_send")]
        public string P_message_send { get; set; }

        [XmlElement(ElementName = "p_subscriber_add")]
        public string P_subscriber_add { get; set; }

        [XmlElement(ElementName = "p_subscriber_edit")]
        public string P_subscriber_edit { get; set; }

        [XmlElement(ElementName = "p_subscriber_delete")]
        public string P_subscriber_delete { get; set; }

        [XmlElement(ElementName = "p_subscriber_import")]
        public string P_subscriber_import { get; set; }

        [XmlElement(ElementName = "p_subscriber_approve")]
        public string P_subscriber_approve { get; set; }

        [XmlElement(ElementName = "luserid")]
        public string Luserid { get; set; }

        [XmlElement(ElementName = "subscribers")]
        public string Subscribers { get; set; }

        [XmlElement(ElementName = "subscribers_active")]
        public string Subscribers_active { get; set; }

        [XmlElement(ElementName = "fields")]
        public List<Fields> Fields { get; set; }

        [XmlElement(ElementName = "groups")]
        public List<Groups> Groups { get; set; }

        [XmlElement(ElementName = "groupsCnt")]
        public string GroupsCnt { get; set; }

        [XmlElement(ElementName = "bounces")]
        public Bounces Bounces { get; set; }

        [XmlElement(ElementName = "analytics_domains_list")]
        public string Analytics_domains_list { get; set; }

        [XmlElement(ElementName = "facebook_oauth_logout_url")]
        public string Facebook_oauth_logout_url { get; set; }

        [XmlElement(ElementName = "facebook_oauth_login_url")]
        public string Facebook_oauth_login_url { get; set; }

        [XmlElement(ElementName = "facebook_oauth_me")]
        public string Facebook_oauth_me { get; set; }

        [XmlElement(ElementName = "subscriber_count")]
        public string Subscriber_count { get; set; }
    }
}