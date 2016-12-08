using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ActiveCampaign.Models
{
    public class Branding : Base
    {
        public Branding(Api api)
        {
            Api = api;
        }

        public string Edit(Dictionary<string, string> postDictionary)
        {
            string postData = null;
            foreach (KeyValuePair<string, string> pair in postDictionary)
            {
                postData += pair.Key + "=" + HttpUtility.UrlEncode(pair.Value) + "&";
            }
            postData = postData?.TrimEnd('&');

            var request = Api.AcUrl + "branding_edit";
            var response = WriteStream(request, postData);

            return response;
        }

        public string View()
        {
            var request = Api.AcUrl + "branding_view";
            var response = ReadStream(request);

            return response;
        }
    }
}