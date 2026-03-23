using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    public class Library
    {
        public string GetBooksXML(List<Book> books)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Book>));
            using (var stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, books);
                string xml = stringWriter.ToString();
                return xml;
            }
        }
    }
}
