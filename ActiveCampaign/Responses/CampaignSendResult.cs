﻿using System.Xml.Serialization;

namespace ActiveCampaign.Responses
{
    [XmlRoot(ElementName = "campaign_ajax_send")]
    public class CampaignSendResult : IApiResult
    {
        [XmlElement(ElementName = "result")]
        public string Result { get; set; }

        [XmlElement(ElementName = "result_code")]
        public int ResultCode { get; set; }

        [XmlElement(ElementName = "result_message")]
        public string ResultMessage { get; set; }

        [XmlElement(ElementName = "result_output")]
        public string ResultOutput { get; set; }
    }
}