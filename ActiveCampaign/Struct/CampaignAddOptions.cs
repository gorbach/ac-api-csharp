using System;
using System.Collections.Generic;

namespace ActiveCampaign.Struct
{
    public class CampaignAddOptions
    {
        public CampaignAddOptions()
        {
            ListDictionary = new Dictionary<int, int>();
            MessageDictionary = new Dictionary<int, int>();
        }

        public CampaignType type { get; set; }
        public int segmentid { get; set; }

        /// <summary>
        /// The internal campaign name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The date when the campaign should be sent out (not used for campaign types 'responder', 'reminder', 'special')
        /// </summary>
        public DateTime sdate { get; set; }

        public CampaignStatus status { get; set; }

        /// <summary>
        /// The visibility of the campaign - if the campaign should be visible on the public side.
        /// </summary>
        public bool Public { get; set; }

        /// <summary>
        /// Whether or not to track links, and what type of links to track. Examples: 'all', 'mime', 'html', 'text', 'none'. Setting this value to 'all' will let the system know to fetch, parse, and track all emails it finds in both TEXT and HTML body. If mime/html/text is provided, then variable 'links' also must exist, with a list of URLs to track. Choosing 'html' or 'text' will track only the links in that message body.
        /// </summary>
        public string tracklinks { get; set; }

        /// <summary>
        /// Whether or not to use the lists' Google Analytics settings
        /// </summary>
        public bool tracklinksanalytics { get; set; }

        /// <summary>
        /// Whether or not to track read
        /// </summary>
        public bool trackreads { get; set; }

        /// <summary>
        /// Whether or not to track replies
        /// </summary>
        public bool trackreplies { get; set; }

        /// <summary>
        /// Set the name of this campaign to use in Google Analytics
        /// </summary>
        public string analytics_campaign_name { get; set; }

        /// <summary>
        /// Whether or not to use lists' Twitter settings
        /// </summary>
        public bool tweet { get; set; }

        /// <summary>
        /// Whether or not to use lists' Facebook settings
        /// </summary>
        public bool facebook { get; set; }

        /// <summary>
        /// Whether or not to append unsubscribe link to the bottom of HTML body
        /// </summary>
        public bool htmlunsub { get; set; }

        /// <summary>
        /// Whether or not to append unsubscribe link to the bottom of HTML body
        /// </summary>
        public Recurring recurring { get; set; }

        /// <summary>
        /// If split mailing. Example: 'even' (send each message to even number of contacts). Possible values are 'even', 'read' and 'click'. If 'read' or 'click' is used, 'split_offset' and 'split_offset_type' need to be present. In that case it will use a "winner" scenario.
        /// </summary>
        public SplitType split_type { get; set; }

        /// <summary>
        /// If split mailing. How much to wait. Example: 12
        /// </summary>
        public int split_offset { get; set; }

        /// <summary>
        /// If auto-responder. How long after (un)subscription to send it. Example: 12.
        /// </summary>
        public int responder_offset { get; set; }

        /// <summary>
        /// If auto-responder. After what to send it. Examples: 'subscribe' and 'unsubscribe'
        /// </summary>
        public string responder_type { get; set; }

        /// <summary>
        /// If auto-reminder. What contact field to use. Examples: cdate, sdate, udate, or an ID of a custom field.
        /// </summary>
        public string reminder_field { get; set; }

        /// <summary>
        /// If auto-reminder. Format in which the date is represented in abovementioned contact field. Example: 'yyyy-mm-dd'
        /// </summary>
        public string reminder_format { get; set; }

        /// <summary>
        /// If auto-reminder. Match just a month and the day (yearly), or match year as well. Examples: 'month_day', 'year_month_day'
        /// </summary>
        public string reminder_type { get; set; }

        /// <summary>
        /// If auto-reminder. How many days/weeks/months/years from that date should it trigger
        /// </summary>
        public int reminder_offset { get; set; }

        /// <summary>
        /// If auto-reminder. How many days/weeks/months/years from that date should it trigger
        /// </summary>
        public string reminder_offset_type { get; set; }

        /// <summary>
        /// If auto-reminder. Examples: + and -. For example: +5days from today needs to be the value of contact's field.
        /// </summary>
        public string reminder_offset_sign { get; set; }

        public string addressid { get; set; }

        /// <summary>
        /// If ActiveRSS. Same options as for recurring mailings
        /// </summary>
        public Recurring activerss_interval { get; set; }

        public Dictionary<int, int> ListDictionary = new Dictionary<int, int>();

        public Dictionary<int, int> MessageDictionary = new Dictionary<int, int>();
    }

    public enum SplitType
    {
        even,
        read,
        click
    }

    public enum Recurring
    {
        day1,
        day2,
        week1,
        week2,
        month1,
        month2,
        quarter1,
        quarter2,
        year1,
        year2
    }

    public enum TrackLinks
    {
        all,
        mime,
        html,
        text,
        none
    }

    public enum CampaignStatus
    {
        draft = 0,
        scheduled = 1
    }

    public enum CampaignType
    {
        single,
        recurring,
        split,
        responder,
        reminder,
        special,
        activerss,
        text
    }

    public enum CampaignSortOptions
    {
        id, cdate
    }

    public enum SortDirections { ASC, DESC }
}