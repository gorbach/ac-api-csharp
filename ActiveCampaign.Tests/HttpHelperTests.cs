using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveCampaign.Models;
using Xunit;
using Xunit.Sdk;

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

            Assert.Equal("&data%5bkeyOne%5d=valueOne&data%5bkeyTwo%5d=valueTwo", result);
        }

        [Fact]
        public void can_format_simple_int_values()
        {
            var c = new Struct.Contact();
            c.ListDictionary.Add(1, 1);
            c.ListDictionary.Add(2, 2);

            var result = HttpHelper.FormatValues("data", c.ListDictionary);

            Assert.Equal("&data%5b1%5d=1&data%5b2%5d=2", result);
        }

        [Fact]
        public void can_encode_field()
        {
            var values = HttpHelper.FormatValues("field", new Dictionary<string, string>() { {"CompanyName", "YourCompany"} }, true);
        }

        [Fact]
        public void all_for_null_ids()
        {
            var r = HttpHelper.IdsStr(null);
            Assert.Equal("all", r);
        }

        [Fact]
        public void all_for_empty_ids()
        {
            var r = HttpHelper.IdsStr();
            Assert.Equal("all", r);
        }

        [Fact]
        public void ids_2_3()
        {
            var r = HttpHelper.IdsStr(2, 3);
            Assert.Equal("2,3", r);
        }
    }
}
