using System.Xml.Serialization;

namespace Adapter;

public class Library()
{
    private static readonly List<Book> DefaultBooks = 
    [
        new Book("Title 1", "Author 1", 1980),
        new Book("Title 2", "Author 2", 1890),
        new Book("Title 3", "Author 3", 1780),
        new Book("Title 4", "Author 4", 1580),
        new Book("Title 5", "Author 5", 1380),
        new Book("Title 6", "Author 6", 2026)
    ];

    public string GetBooksXML()
    {
        var xmlSerializer = new XmlSerializer(typeof(List<Book>));
        using (var stringWriter = new StringWriter())
        {
            xmlSerializer.Serialize(stringWriter, DefaultBooks);
            string xml = stringWriter.ToString();

            return xml;
        }
    }
}

