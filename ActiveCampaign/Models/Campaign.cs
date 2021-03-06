﻿using ActiveCampaign.Helpers;
using ActiveCampaign.Responses;
using ActiveCampaign.Struct;

namespace ActiveCampaign.Models
{
    public class Campaign : Base
    {
        public Campaign(Api api)
        {
            Api = api;
        }

        public CampaignCreateResult Add(CampaignAddOptions options)
        {
            var request = Api.AcUrl + "campaign_create";

            string postData = "type=" + options.type.ToString();
            postData += "&segmentid=" + options.segmentid;
            postData += "&name=" + options.name;
            postData += "&sdate=" + HttpHelper.Date(options.sdate);
            postData += "&status=" + ((int)options.status).ToString();
            postData += "&public=" + HttpHelper.Bool(options.Public);
            postData += "&tracklinks=" + options.tracklinks;
            postData += "&tracklinksanalytics=" + HttpHelper.Bool(options.tracklinksanalytics);
            postData += "&trackreads=" + HttpHelper.Bool(options.trackreads);
            postData += "&trackreplies=" + HttpHelper.Bool(options.trackreplies);
            postData += "&analytics_campaign_name=" + options.analytics_campaign_name;
            postData += "&tweet=" + HttpHelper.Bool(options.tweet);
            postData += "&facebook=" + HttpHelper.Bool(options.facebook);
            postData += "&htmlunsub=" + HttpHelper.Bool(options.htmlunsub);
            postData += "&recurring=" + options.recurring;
            postData += "&split_type=" + options.split_type;
            postData += "&split_type=" + options.split_offset;
            postData += "&responder_offset=" + options.responder_offset;
            postData += "&responder_type=" + options.responder_type;
            postData += "&reminder_field=" + options.reminder_field;
            postData += "&reminder_format=" + options.reminder_format;
            postData += "&reminder_type=" + options.reminder_type;
            postData += "&reminder_offset_type=" + options.reminder_offset_type;
            postData += "&reminder_offset_sign=" + options.reminder_offset_sign;
            postData += "&activerss_interval=" + options.activerss_interval;
            postData += "&addressid=" + options.addressid;
            postData += HttpHelper.FormatValues("p", options.ListDictionary);
            postData += HttpHelper.FormatValues("m", options.MessageDictionary);
            return SendRequest<CampaignCreateResult>(request, postData);
        }

        public CampaignSelectListResult List(CampaignListOptions options)
        {
            var request = Api.AcUrl + "campaign_list";

            string postData = "full=" + HttpHelper.Bool(options.full);
            postData += "&ids=" + HttpHelper.IdsStr(options.Ids);
            postData += "&sort=" + options.sort.ToString();
            postData += HttpHelper.FormatValues("filters", options.Filters);
            postData += "&sort_direction=" + options.sort_direction;
            postData += "&page=" + options.page;
            return SendRequest<CampaignSelectListResult>(request, postData);
        }

        /// <summary>
        /// Re-send an existing campaign using optional actions like 'copy', 'preview', 'test'.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public CampaignSendResult Send(CampaignSendOptions options)
        {
            var request = Api.AcUrl + "campaign_send";

            string postData = "email=" + options.email;
            postData += "&campaignid=" + options.campaignid;
            postData += "&messageid=" + options.messageid;
            postData += "&type=" + options.type;
            postData += "&action=" + options.action;
            return SendRequest<CampaignSendResult>(request, postData);
        }

        /// <summary>
        /// Allows you to delete multiple campaigns at once.
        /// </summary>
        /// <param name="ids">ID's of the campaigns you wish to delete</param>
        /// <returns></returns>
        public CampaignDeleteMultiResult Delete(int[] ids)
        {
            var request = Api.AcUrl + "campaign_delete_list";

            string postData = "ids=" + HttpHelper.IdsStr(ids);
            return SendRequest<CampaignDeleteMultiResult>(request, postData);
        }
    }
}