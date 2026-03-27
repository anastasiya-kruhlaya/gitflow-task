using System.Text.Json;

namespace Adapter;

public class BooksAnalyzer
{
    private const int BookAmount = 3;

    public static string GetOldestBooks(IBooksProvider booksProvider)
    {
        string jsonBooks = booksProvider.GetBooks();
        var listBooks = JsonSerializer.Deserialize<List<Book>>(jsonBooks);
        var oldestBooks = listBooks?
            .OrderBy(b => b.YearOfPublication)
            .TakeLast(BookAmount)
            .ToList();
        var jsonOldestBooks = JsonSerializer.Serialize(oldestBooks);

        return jsonOldestBooks;
    }
}

