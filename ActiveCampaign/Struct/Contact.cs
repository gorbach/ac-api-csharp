using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveCampaign.Struct
{
    public class Contact : CoreStruct
    {
        public int Id = 0;
        public string Email = null;
        public string FirstName = null;
        public string LastName = null;
        public string Phone = null;
        public string OrgName = null;
        public List<string> Tags = new List<string>();
        public string Ip4 = null;
        public Dictionary<string, string> FieldDictionary = new Dictionary<string, string>();
        public Dictionary<int, int> ListDictionary = new Dictionary<int, int>();
        public Dictionary<int, int> StatusDictionary = new Dictionary<int, int>();
        public int Form = 0;
        public Dictionary<int, int> NoRespondersDictionary = new Dictionary<int, int>();
        public Dictionary<int, string> SDateDictionary = new Dictionary<int, string>();
        public Dictionary<int, int> InstantRespondersDictionary = new Dictionary<int, int>();
        public Dictionary<int, int> LastMessageDictionary = new Dictionary<int, int>();
    }
}