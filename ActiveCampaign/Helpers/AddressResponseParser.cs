using System.Text.RegularExpressions;
using ActiveCampaign.Responses.Address;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ActiveCampaign.Helpers
{
    public class AddressResponseParser
    {
        public static AddressListResponse Parse(string json)
        {
            var parsed = JObject.Parse(json);

            var root = JsonConvert.DeserializeObject<AddressListResponse>(json);

            foreach (var item in parsed)
            {
                if (Regex.IsMatch(item.Key, @"\d+"))
                {
                    var address = JsonConvert.DeserializeObject<AddressListLine>(item.Value.ToString());
                    root.Addresses.Add(address);
                }
               
            }

            return root;
        }
    }
}