using System.Text.Json;
using System.Xml.Serialization;

namespace Adapter;

public class FormatAdapter : IFormatAnalyzer
{
    public string ReturnBooks(string xmlBooks)
    {
        List<Book> books = null;
        var xmlSerialize = new XmlSerializer(typeof(List<Book>));
        
        using (var stringReader = new StringReader(xmlBooks))
        {
            books = (List<Book>)xmlSerialize.Deserialize(stringReader);
        }

        var jsonBooks = JsonSerializer.Serialize(books);
        return BooksAnalyzer.GetOldestBooks(jsonBooks);
    }
}

