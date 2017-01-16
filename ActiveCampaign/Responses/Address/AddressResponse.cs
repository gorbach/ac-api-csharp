using System.Collections.Generic;

namespace ActiveCampaign.Responses.Address
{
    public class Links
    {
        public string addressGroup { get; set; }
        public string addressList { get; set; }
        public string forms { get; set; }
    }

    public class AddressAddResult
    {
        public string id { get; set; }
        public string fullAddress { get; set; }
        public string company_name { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public int allgroup { get; set; }
        public Links links { get; set; }
        public int success { get; set; }
        public string message { get; set; }
        public int result_code { get; set; }
        public string result_message { get; set; }
        public string result_output { get; set; }
    }

    public class AddressListResponse
    {
        public int success { get; set; }
        public string message { get; set; }
        public int result_code { get; set; }
        public string result_message { get; set; }
        public string result_output { get; set; }

        public List<AddressListLine> Addresses { get; set; }

        public AddressListResponse()
        {
            Addresses = new List<AddressListLine>();
        }
    }

    public class AddressListLine
    {
        public string id { get; set; }
        public string company_name { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string allgroup { get; set; }
        //public List<object> lists { get; set; }
        //public Groups groups { get; set; }
    }
}