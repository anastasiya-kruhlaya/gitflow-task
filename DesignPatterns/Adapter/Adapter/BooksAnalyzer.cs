using System.Text.Json;
namespace Adapter;

public class BooksAnalyzer
{
    public static string GetOldestBooks(IBooksProvider booksProvider)
    {
        string jsonBooks = booksProvider.GetBooks();
        var listBooks = JsonSerializer.Deserialize<List<Book>>(jsonBooks);
        var oldestBooks = listBooks.OrderBy(b => b.YearOfPublication).TakeLast(3).ToList();
        var jsonOldestBooks = JsonSerializer.Serialize(oldestBooks);

        return jsonOldestBooks;
    }
}

