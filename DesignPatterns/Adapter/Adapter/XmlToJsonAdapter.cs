using System.Text.Json;
using System.Xml.Serialization;

namespace Adapter;

public class XmlToJsonAdapter : IBooksProvider
{
    private readonly Library _library;
    public XmlToJsonAdapter(Library library)
    {
        _library = library;
    }
    public string GetBooks()
    {
        List<Book> books = null;
        var xmlSerialize = new XmlSerializer(typeof(List<Book>));
        
        using (var stringReader = new StringReader(_library.GetBooksXML()))
        {
            books = (List<Book>) xmlSerialize.Deserialize(stringReader);
        }

        var jsonBooks = JsonSerializer.Serialize(books);

        return jsonBooks;
    }
}

