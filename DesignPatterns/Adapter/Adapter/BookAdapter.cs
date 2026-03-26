using System.Text.Json;
using System.Xml.Serialization;

namespace Adapter;

public class BookAdapter : IBooksProvider
{
    private readonly Library _library;
    public BookAdapter(Library library)
    {
        _library = library;
    }
    public string GetBooks()
    {
        List<Book> books = [];
        var xmlSerialize = new XmlSerializer(typeof(List<Book>));
        
        using (var stringReader = new StringReader(_library.GetBooksXML()))
        {
            books = xmlSerialize.Deserialize(stringReader) as List<Book> ?? [];
        }

        var jsonBooks = JsonSerializer.Serialize(books);

        return jsonBooks;
    }
}

