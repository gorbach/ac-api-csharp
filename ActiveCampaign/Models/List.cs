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

            var idsStr = "all";

            if (ids == null || ids.Any())
            {
                idsStr = string.Join(",", ids.Select(x => x.ToString()).ToArray());
            }

            string postData = "ids=" + idsStr;

            return SendRequest<FieldsListResult>(request, postData);
        }

        public ListFieldInsertResult ListFieldAdd(ListField field)
        {
            var request = Api.AcUrl + "list_field_add";

            string postData = "title=" + field.Title +
                              "&type=" + (int)field.ListFieldType +
                              "&perstag=" + field.Perstag +
                              "&p[0]=" + "0" + // all lists
                              "&req=" + (field.Required ? "1" : "0");

            return SendRequest<ListFieldInsertResult>(request, postData);
        }
    }
}