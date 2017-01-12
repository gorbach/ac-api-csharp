namespace ActiveCampaign.Struct
{
    public class CampaignSendOptions
    {
        /// <summary>
        /// Email address (of the contact) that will be receiving the email
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// ID of the campaign you wish to send 
        /// </summary>
        public int campaignid { get; set; }

        /// <summary>
        /// ID of the campaign's message you wish to send (used in Split campaigns if you have more than one message assigned to a campaign).
        /// </summary>
        public int messageid { get; set; }

        /// <summary>
        /// Type of the message you wish to send (can be used to send TEXT-only email even if campaign is set to use MIME).
        /// </summary>
        public CampaignSendTypes type { get; set; }

        /// <summary>
        /// Examples: 'send' = send a campaign to this contact and to append him to the recipients list, 'copy' = send a copy of a campaign to contact (campaign is not updated), 'test' = send a test email to contact (campaign is not updated), 'source' = simulate a campaign test to contact (campaign is not updated), return message source, 'messagesize' = simulate a campaign test to contact (campaign is not updated), return message size, 'spamcheck' = simulate a campaign test to contact (campaign is not updated), return spam rate, 'preview' = same as preview
        /// </summary>
        public CapmaignSendActions action { get; set; }
    }

    public enum CampaignSendTypes
    {
        mime, text, html
    }

    public enum CapmaignSendActions
    {
        send,
        copy,
        test,
        source,
        spamcheck,
        preview
    }
}