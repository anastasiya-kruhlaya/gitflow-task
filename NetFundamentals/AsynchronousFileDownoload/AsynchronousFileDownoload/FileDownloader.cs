namespace AsynchronousFileDownoload;

public class FileDownloader
{
    public static readonly HttpClient httpClient = new HttpClient();

    public static async Task DownloadFileAsync(string url, CancellationToken cancellationToken)
    {
        using HttpResponseMessage response = await httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        string filePath = GetFilePath(url, response);

        byte[] fileBytes = await response.Content.ReadAsByteArrayAsync(cancellationToken);
        await File.WriteAllBytesAsync(filePath, fileBytes, cancellationToken);

        Console.WriteLine($"File saved successfully: {filePath}");
    }

    public static string GetFilePath(string url, HttpResponseMessage response)
    {
        string directory = Path.Combine(AppContext.BaseDirectory, "Downloads");
        Directory.CreateDirectory(directory);

        string fileName = Path.GetFileName(new Uri(url).LocalPath);

        if (string.IsNullOrWhiteSpace(fileName) || !Path.HasExtension(fileName))
        {
            string? contentType = response.Content.Headers.ContentType?.MediaType;
            string extension = UrlReader.GetExtensionFromContentType(contentType);
            fileName = string.IsNullOrWhiteSpace(fileName)
                ? $"file_{DateTime.Now:yyyyMMdd_HHmmss}{extension}"
                : fileName + extension;
        }

        return Path.Combine(directory, fileName);
    }
}
