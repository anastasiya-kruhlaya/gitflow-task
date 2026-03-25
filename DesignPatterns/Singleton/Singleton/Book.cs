namespace Singleton;

public class Book(string title, string author)
{
    private string? _title = title;
    public string? _author =author;
    
    public override string ToString()
    {
        return $"{_title}, {_author}";
    }
}

