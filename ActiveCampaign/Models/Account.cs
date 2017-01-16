using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActiveCampaign.Responses;

namespace ActiveCampaign.Models
{
    public class Account : Base
    {
        public Account(Api api)
        {
            Api = api;
        }

        public AccountGetResult View()
        {
            var request = Api.AcUrl + "account_view";
            var response = SendRequest<AccountGetResult>(request);
            return response;
        }
    }
}