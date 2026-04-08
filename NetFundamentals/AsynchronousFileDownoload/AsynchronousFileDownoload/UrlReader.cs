namespace AsynchronousFileDownoload;

public class UrlReader
{
    public static List<string> ReadUrls()
    {
        var urls = new List<string>();

        Console.WriteLine("Enter URL");
        Console.WriteLine("Press <Enter> for stop input\n");

        while (true)
        {
            string? input = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(input))
                break;

            if (!Uri.TryCreate(input, UriKind.Absolute, out _))
            {
                Console.WriteLine("Wrong input\n");
                continue;
            }

            urls.Add(input);
        }

        return urls;
    }

    public static string GetExtensionFromContentType(string? contentType) =>
    contentType switch
    {
        "image/png" => ".png",
        "image/jpeg" => ".jpg",
        "image/gif" => ".gif",
        "image/webp" => ".webp",
        "application/pdf" => ".pdf",
        "application/zip" => ".zip",
        "application/json" => ".json",
        "text/plain" => ".txt",
        "text/html" => ".html",
        "video/mp4" => ".mp4",
        "audio/mpeg" => ".mp3",
        _ => ".bin"
    };
}
