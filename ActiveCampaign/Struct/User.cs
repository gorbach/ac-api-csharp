using System.Collections.Generic;

namespace ActiveCampaign.Struct
{
    public struct User
    {
        public string Username;
        public string Password;
        public string PasswordR;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Phone;
        public Dictionary<int, int> GroupDictionary;
        public string Language;
        public string Timezone;
    }
}