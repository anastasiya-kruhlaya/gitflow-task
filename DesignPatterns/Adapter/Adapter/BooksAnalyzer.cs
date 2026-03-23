using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Adapter
{
    public class BooksAnalyzer
    {
        public static string GetOldestBooks(string jsonBooks)
        {
            var listBooks = JsonSerializer.Deserialize<List<Book>>(jsonBooks);
            var oldestBooks = listBooks.OrderBy(b => b.YearOfPublication).TakeLast(3).ToList();
            var jsonOldestBooks = JsonSerializer.Serialize(oldestBooks);
            return jsonOldestBooks;
        }
    }
}
