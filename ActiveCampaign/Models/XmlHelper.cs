using System.IO;
using System.Xml.Serialization;

namespace ActiveCampaign.Models
{
    public class XmlHelper
    {
        public static T Deserialize<T>(string xml)
        {
            using (TextReader textReader = new StringReader(xml))
            {
                var ser = new XmlSerializer(typeof(T));
                return (T)ser.Deserialize(textReader);
            }
        }
    }
}