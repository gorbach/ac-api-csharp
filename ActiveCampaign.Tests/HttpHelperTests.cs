using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCampaign.Models;
using Xunit;

namespace ActiveCampaign.Tests
{
    public class HttpHelperTests
    {
        [Fact]
        public void can_format_simple_string_values()
        {
            var c = new Struct.Contact();
            c.FieldDictionary.Add("keyOne", "valueOne");
            c.FieldDictionary.Add("keyTwo", "valueTwo");

            var result = HttpHelper.FormatValues("data", c.FieldDictionary);

            Assert.Equal("&data[keyOne]=valueOne&data[keyTwo]=valueTwo", result);
        }

        [Fact]
        public void can_format_simple_int_values()
        {
            var c = new Struct.Contact();
            c.ListDictionary.Add(1, 1);
            c.ListDictionary.Add(2, 2);

            var result = HttpHelper.FormatValues("data", c.ListDictionary);

            Assert.Equal("&data[1]=1&data[2]=2", result);
        }

        [Fact]
        public void can_encode_field()
        {
            var values = HttpHelper.FormatValues("field", new Dictionary<string, string>() { {"CompanyName", "YourCompany"} }, true);
        }
    }
}
