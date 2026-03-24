using System.Text.Json;

namespace Adapter;

public class Program()
{
    public static void Main()
    {
        var books = new List<Book>
        {
            new Book("Title 1", "Author 1", 1980),
            new Book("Title 2", "Author 2", 1890),
            new Book("Title 3", "Author 3", 1780),
            new Book("Title 4", "Author 4", 1580),
            new Book("Title 5", "Author 5", 1380),
            new Book("Title 6", "Author 6", 2026)
        };
        string file = "BooksJson.json";
        var jsonBooks = JsonSerializer.Serialize(books);
        File.WriteAllText(file, jsonBooks);

        var library = new Library();
        var xml = library.GetBooksXML(books);
        Console.WriteLine(xml + '\n');

        var formatAdapter = new FormatAdapter();
        var json = formatAdapter.ReturnBooks(xml);
        Console.WriteLine(json);
    }
}