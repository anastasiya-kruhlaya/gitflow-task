using System.Text;

namespace Singleton;

public class Database
{
    public List<Book> Books {  get; set; }

    private Database()
    {
        Books = new List<Book>();
    }

    public override string ToString()
    {
        var output = new StringBuilder();
        foreach (Book book in Books)
        {
            output.AppendLine(book.ToString());
        }
        return output.ToString();
    }

    private static Database databaseInstance = new Database();

    public static Database PublicDatabaseInstance => databaseInstance;
}

