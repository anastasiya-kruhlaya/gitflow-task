using System.Text.Json;

namespace Adapter;

public class Program()
{
    public static void Main()
    {
        var library = new Library();
        var xml = library.GetBooksXML();
        Console.WriteLine(xml + '\n');
        
        var xmlToJsonAdapter = new XmlToJsonAdapter(library);
        var json = xmlToJsonAdapter.GetBooks();
        Console.WriteLine(json);
    }
}