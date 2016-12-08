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
        public User User;

        public Api(string apiUrl, string apiKey, bool debug, string output)
        {
            ApiUrl = apiUrl;
            ApiKey = apiKey;
            Debug = debug;

            // Build the URL
            AcUrl = ApiUrl + "/admin/api.php?api_key=" + ApiKey + "&api_ouput=" + output + "&api_action=";

            User = new User(this);
        }

        public Api(string apiUrl, string apiKey, bool debug) : this(apiUrl, apiKey, debug, "xml")
        {
        }

        public string ReadStream(string url)
        {
            string data = null;

            var request = (HttpWebRequest) WebRequest.Create(url);
            var response = (HttpWebResponse) request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var apiStream = response.GetResponseStream();
                if (apiStream != null)
                {
                    var apiReader = new StreamReader(apiStream);
                    data = apiReader.ReadToEnd();
                    apiStream.Close();
                }
            }
            response.Close();
            return data;
        }
    }
}