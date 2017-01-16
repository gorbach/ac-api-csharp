using ActiveCampaign.Helpers;
using ActiveCampaign.Responses.Address;
using ActiveCampaign.Struct;
using Newtonsoft.Json;

namespace ActiveCampaign.Models
{
    public class Address : Base
    {
        public Address(Api api)
        {
            Api = api;
        }

        public AddressAddResult Add(AddressAddOptions options)
        {
            var request = Api.AcUrl + "address_add";

            string postData = "company_name=" + options.CompanyName;
            postData += "&address_1=" + options.addr_1;
            postData += "&address_2=" + options.addr_2;
            postData += "&city=" + options.city;
            postData += "&state=" + options.state;
            postData += "&zip=" + options.zip;
            postData += "&country=" + options.country;
            postData += "&allgroup=" + HttpHelper.Bool(options.allgroup);
            postData += "&country=" + options.country;
            postData += HttpHelper.FormatValues("list", options.list);
            postData += HttpHelper.FormatValues("group", options.group);

            var resultStr = WriteStream(request, postData);
            return JsonConvert.DeserializeObject<AddressAddResult>(resultStr);
        }

        public AddressDeleteResult Delete(int id)
        {
            var request = Api.AcUrl + "address_delete";

            string postData = "id=" + id;

            return JsonConvert.DeserializeObject<AddressDeleteResult>(WriteStream(request, postData));
        }

        /// <summary>
        /// View many (or all) addresses by including their ID's.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <param name="sortd"></param>
        /// <returns></returns>
        public AddressListResponse List(int page = 0, string sort = "id", SortDirections sortd = SortDirections.ASC)
        {
            var request = Api.AcUrl + "address_list";

            string postData = "page=" + page;
            postData += "&sort=" + sort;
            postData += "&sortd=" + sortd;

            return AddressResponseParser.Parse(WriteStream(request, postData));
        }
    }
}