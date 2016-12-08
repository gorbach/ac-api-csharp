using System.IO;
using System.Net;
using ActiveCampaign.Models;

namespace ActiveCampaign
{
    public class Api
    {
        // Defined URL
        public string AcUrl;
        public string ApiKey;
        public string ApiUrl;
        public bool Debug;
        public string Output = "xml";

        // Load Models
        public Account Account;
        public Automation Automation;
        public User User;

        public Api(string apiUrl, string apiKey, bool debug, string output)
        {
            ApiUrl = apiUrl;
            ApiKey = apiKey;
            Debug = debug;

            // Build the URL
            AcUrl = ApiUrl + "/admin/api.php?api_key=" + ApiKey + "&api_ouput=" + output + "&api_action=";

            User = new User(this);
            Account = new Account(this);
        }

        public Api(string apiUrl, string apiKey, bool debug) : this(apiUrl, apiKey, debug, "xml")
        {
        }
    }
}