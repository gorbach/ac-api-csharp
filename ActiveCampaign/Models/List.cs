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

        public string ListList(ListListOptions options)
        {
            var request = Api.AcUrl + "list_list";

            string postData = "ids=" + "ids=" + HttpHelper.IdsStr(options.Ids);

            postData += HttpHelper.FormatValues("filters", options.Filters);
            postData += "&global_fields=" + HttpHelper.Bool(options.GlobalFields);
            postData += "&full=" + HttpHelper.Bool(options.Full);

            return WriteStream(request, postData);
        }
    }
}