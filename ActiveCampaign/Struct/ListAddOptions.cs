namespace ActiveCampaign.Struct
{
    public class ListAddOptions
    {
        /// <summary>
        /// Internal list name. Example: 'List Name'
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Comma-separated list of email addresses to notify on new subscriptions to this list
        /// </summary>
        public string subscription_notify { get; set; }

        /// <summary>
        /// Comma-separated list of email addresses to notify on any unsubscriptions from this list
        /// </summary>
        public string unsubscription_notify { get; set; }

        /// <summary>
        /// If contact doesn't enter a name, use this. Example: 'Recipient'
        /// </summary>
        public string to_name { get; set; }

        /// <summary>
        /// Comma-separated list of email addresses to send a copy of all mailings to upon send
        /// </summary>
        public string carboncopy { get; set; }

        /// <summary>
        /// URL-safe list name. Example: 'api-test'
        /// </summary>
        public string stringid { get; set; }

        /// <summary>
        /// Whether or not to send this campaign to Twitter.
        /// </summary>
        public bool p_use_twitter { get; set; }

        /// <summary>
        /// Twitter Account Username
        /// </summary>
        public string twitter_user { get; set; }

        /// <summary>
        /// Twitter Account Password
        /// </summary>
        public string twitter_pass { get; set; }

        /// <summary>
        /// Twitter Account Password
        /// </summary>
        public bool send_last_broadcast { get; set; }

        /// <summary>
        /// Whether or not to require name with email when subscribing.
        /// </summary>
        public bool require_name { get; set; }

        /// <summary>
        /// Whether or not to hide it on public side (direct links to it will still work though). 
        /// </summary>
        public bool Private { get; set; }

        /// <summary>
        /// Company (or Organization)
        /// </summary>
        public string sender_name { get; set; }

        /// <summary>
        /// Physical mailing address
        /// </summary>
        public string sender_addr1 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string sender_city { get; set; }

        /// <summary>
        /// Physical mailing address: zip or postal code
        /// </summary>
        public string sender_zip { get; set; }

        /// <summary>
        /// Physical mailing address country
        /// </summary>
        public string sender_country { get; set; }

        /// <summary>
        /// Website associated with this list
        /// </summary>
        public string sender_url { get; set; }

        /// <summary>
        /// Remind your contacts why they are on this list and why you are emailing them
        /// </summary>
        public string sender_reminder { get; set; }
    }
}