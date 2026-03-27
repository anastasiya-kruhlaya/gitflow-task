namespace Adapter;

public class Book(string name, string author, int yearOfPublication)
{
    public string Name { get; set; } = name;
    public string Author { get; set; } = author;
    public int YearOfPublication { get; set; } = yearOfPublication;

    public Book() : this(string.Empty, string.Empty, 0)
    {
    }
}

