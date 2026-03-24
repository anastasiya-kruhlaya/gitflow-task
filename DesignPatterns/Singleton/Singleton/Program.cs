namespace Singleton;

class Progrma
{
    public static void Main()
    {
        var database = Database.PublicDatabaseInstance;
        database.Books.Add(new Book("Title1","Author1"));
        Console.WriteLine(database);

        var database2 = Database.PublicDatabaseInstance;
        database.Books.Add(new Book("Title2", "Author2"));
        Console.WriteLine(database2.ToString());
    }
}