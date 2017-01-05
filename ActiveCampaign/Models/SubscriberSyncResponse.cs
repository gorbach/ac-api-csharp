﻿using System.Xml.Serialization;

namespace ActiveCampaign.Models
{
    [XmlRoot(ElementName = "subscriber_sync")]
    public class SubscriberSyncResponse : IApiResult
    {
        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }
}