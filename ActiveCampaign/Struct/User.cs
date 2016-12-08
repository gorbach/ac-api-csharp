using System;
using System.Collections.Generic;

namespace ActiveCampaign.Struct
{
    public class User : CoreStruct
    {
        public int Id = 0;
        public string Username = null;
        public string Password = null;
        public string PasswordR = null;
        public string FirstName = null;
        public string LastName = null;
        public string Email = null;
        public string Phone = null;
        public Dictionary<int, int> GroupDictionary;
        public string Language = null;
        public string Timezone = null;
    }
}