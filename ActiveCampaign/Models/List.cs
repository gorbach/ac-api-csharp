using System.Linq;
using ActiveCampaign.Responses;
using ActiveCampaign.Struct;

namespace ActiveCampaign.Models
{
    public class Lists : Base
    {
        public Lists(Api api)
        {
            Api = api;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids">ID's of the contact custom field you want to view(empty or null if you want to view all)</param>
        /// <returns></returns>
        public FieldsListResult ListFieldView(params int[] ids)
        {
            var request = Api.AcUrl + "list_field_view";

            string postData = "ids=" + HttpHelper.IdsStr(ids);

            return SendRequest<FieldsListResult>(request, postData);
        }

        public ListFieldInsertResult ListFieldAdd(ListField field)
        {
            var request = Api.AcUrl + "list_field_add";

            string postData = "title=" + field.Title +
                              "&type=" + (int)field.ListFieldType +
                              "&perstag=" + field.Perstag +
                              "&p[0]=" + "0" + // all lists
                              "&req=" + HttpHelper.Bool(field.Required);

            return SendRequest<ListFieldInsertResult>(request, postData);
        }

        public ListSelectList ListList(ListListOptions options)
        {
            var request = Api.AcUrl + "list_list";

            string postData = "ids=" + HttpHelper.IdsStr(options.Ids);

            postData += HttpHelper.FormatValues("filters", options.Filters);
            postData += "&global_fields=" + HttpHelper.Bool(options.GlobalFields);
            postData += "&full=" + HttpHelper.Bool(options.Full);

            return SendRequest<ListSelectList>(request, postData);
        }


        public ListInsertResult Add(ListAddOptions options)
        {
            var request = Api.AcUrl + "list_add";

            string postData = "name=" + options.Name;
            postData += "&subscription_notify=" + options.subscription_notify;
            postData += "&unsubscription_notify=" + options.unsubscription_notify;
            postData += "&to_name=" + options.to_name;
            postData += "&carboncopy=" + options.carboncopy;
            postData += "&stringid=" + options.stringid;
            postData += "&p_use_twitter=" + HttpHelper.Bool(options.p_use_twitter);
            postData += "&twitter_user=" + options.twitter_user;
            postData += "&twitter_pass=" + options.twitter_pass;
            postData += "&send_last_broadcast=" + HttpHelper.Bool(options.send_last_broadcast);
            postData += "&require_name=" + HttpHelper.Bool(options.require_name);
            postData += "&private=" + HttpHelper.Bool(options.Private);
            postData += "&sender_name=" + options.sender_name;
            postData += "&sender_city=" + options.sender_city;
            postData += "&sender_addr1=" + options.sender_addr1;
            postData += "&sender_zip=" + options.sender_zip;
            postData += "&sender_country=" + options.sender_country;
            postData += "&sender_url=" + options.sender_url;
            postData += "&sender_reminder=" + options.sender_reminder;

            return SendRequest<ListInsertResult>(request, postData);
        }
    }
}