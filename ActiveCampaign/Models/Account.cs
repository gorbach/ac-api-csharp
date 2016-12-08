using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveCampaign.Models
{
    public class Account : Base
    {
        public Account(Api api)
        {
            Api = api;
        }

        public string View()
        {
            var request = Api.AcUrl + "account_view";
            var response = ReadStream(request);
            return response;
        }
    }
}