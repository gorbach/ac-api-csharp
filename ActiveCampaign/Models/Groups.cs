using System.Xml.Serialization;

namespace ActiveCampaign.Models
{
    [XmlRoot(ElementName = "groups")]
    public class Groups
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "descript")]
        public string Descript { get; set; }
        [XmlElement(ElementName = "unsubscribelink")]
        public string Unsubscribelink { get; set; }
        [XmlElement(ElementName = "optinconfirm")]
        public string Optinconfirm { get; set; }
        [XmlElement(ElementName = "p_admin")]
        public string P_admin { get; set; }
        [XmlElement(ElementName = "pg_list_add")]
        public string Pg_list_add { get; set; }
        [XmlElement(ElementName = "pg_list_edit")]
        public string Pg_list_edit { get; set; }
        [XmlElement(ElementName = "pg_list_delete")]
        public string Pg_list_delete { get; set; }
        [XmlElement(ElementName = "pg_list_headers")]
        public string Pg_list_headers { get; set; }
        [XmlElement(ElementName = "pg_list_emailaccount")]
        public string Pg_list_emailaccount { get; set; }
        [XmlElement(ElementName = "pg_list_bounce")]
        public string Pg_list_bounce { get; set; }
        [XmlElement(ElementName = "pg_message_add")]
        public string Pg_message_add { get; set; }
        [XmlElement(ElementName = "pg_message_edit")]
        public string Pg_message_edit { get; set; }
        [XmlElement(ElementName = "pg_message_delete")]
        public string Pg_message_delete { get; set; }
        [XmlElement(ElementName = "pg_message_send")]
        public string Pg_message_send { get; set; }
        [XmlElement(ElementName = "pg_subscriber_add")]
        public string Pg_subscriber_add { get; set; }
        [XmlElement(ElementName = "pg_subscriber_edit")]
        public string Pg_subscriber_edit { get; set; }
        [XmlElement(ElementName = "pg_subscriber_delete")]
        public string Pg_subscriber_delete { get; set; }
        [XmlElement(ElementName = "pg_subscriber_import")]
        public string Pg_subscriber_import { get; set; }
        [XmlElement(ElementName = "pg_subscriber_approve")]
        public string Pg_subscriber_approve { get; set; }
        [XmlElement(ElementName = "pg_subscriber_export")]
        public string Pg_subscriber_export { get; set; }
        [XmlElement(ElementName = "pg_subscriber_sync")]
        public string Pg_subscriber_sync { get; set; }
        [XmlElement(ElementName = "pg_subscriber_filters")]
        public string Pg_subscriber_filters { get; set; }
        [XmlElement(ElementName = "pg_subscriber_actions")]
        public string Pg_subscriber_actions { get; set; }
        [XmlElement(ElementName = "pg_subscriber_fields")]
        public string Pg_subscriber_fields { get; set; }
        [XmlElement(ElementName = "pg_user_add")]
        public string Pg_user_add { get; set; }
        [XmlElement(ElementName = "pg_user_edit")]
        public string Pg_user_edit { get; set; }
        [XmlElement(ElementName = "pg_user_delete")]
        public string Pg_user_delete { get; set; }
        [XmlElement(ElementName = "pg_group_add")]
        public string Pg_group_add { get; set; }
        [XmlElement(ElementName = "pg_group_edit")]
        public string Pg_group_edit { get; set; }
        [XmlElement(ElementName = "pg_group_delete")]
        public string Pg_group_delete { get; set; }
        [XmlElement(ElementName = "pg_template_add")]
        public string Pg_template_add { get; set; }
        [XmlElement(ElementName = "pg_template_edit")]
        public string Pg_template_edit { get; set; }
        [XmlElement(ElementName = "pg_template_delete")]
        public string Pg_template_delete { get; set; }
        [XmlElement(ElementName = "pg_personalization_add")]
        public string Pg_personalization_add { get; set; }
        [XmlElement(ElementName = "pg_personalization_edit")]
        public string Pg_personalization_edit { get; set; }
        [XmlElement(ElementName = "pg_personalization_delete")]
        public string Pg_personalization_delete { get; set; }
        [XmlElement(ElementName = "pg_form_edit")]
        public string Pg_form_edit { get; set; }
        [XmlElement(ElementName = "pg_reports_campaign")]
        public string Pg_reports_campaign { get; set; }
        [XmlElement(ElementName = "pg_reports_list")]
        public string Pg_reports_list { get; set; }
        [XmlElement(ElementName = "pg_reports_user")]
        public string Pg_reports_user { get; set; }
        [XmlElement(ElementName = "pg_reports_trend")]
        public string Pg_reports_trend { get; set; }
        [XmlElement(ElementName = "pg_startup_reports")]
        public string Pg_startup_reports { get; set; }
        [XmlElement(ElementName = "pg_startup_gettingstarted")]
        public string Pg_startup_gettingstarted { get; set; }
        [XmlElement(ElementName = "sdate")]
        public string Sdate { get; set; }
        [XmlElement(ElementName = "req_approval")]
        public string Req_approval { get; set; }
        [XmlElement(ElementName = "req_approval_1st")]
        public string Req_approval_1st { get; set; }
        [XmlElement(ElementName = "req_approval_notify")]
        public string Req_approval_notify { get; set; }
        [XmlElement(ElementName = "socialdata")]
        public string Socialdata { get; set; }
        [XmlElement(ElementName = "listid")]
        public string Listid { get; set; }
        [XmlElement(ElementName = "groupid")]
        public string Groupid { get; set; }
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
    }
}