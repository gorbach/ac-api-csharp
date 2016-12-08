using System;

namespace ActiveCampaign.Models
{
    public class User : Base
    {
        public User(Api api)
        {
            Api = api;
        }

        public string Me()
        {
            var request = Api.AcUrl + "user_me";
            var response = Api.ReadStream(request);
            return response;
        }

        public string Add(Struct.User user)
        {
            var request = Api.ApiUrl + "user_+add";
        }
    }
}