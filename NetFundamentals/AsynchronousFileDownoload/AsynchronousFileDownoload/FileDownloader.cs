namespace AsynchronousFileDownoload;
public class FileDownloader
{
    public static readonly HttpClient httpClient = new HttpClient();
    public static async Task DownloadFileAsync(string url, CancellationToken cancellationToken)
    {
        string directory = Path.Combine(AppContext.BaseDirectory, "Downloads");
        Directory.CreateDirectory(directory);

        using HttpResponseMessage response = await httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        string fileName = Path.GetFileName(new Uri(url).LocalPath);

        if (string.IsNullOrWhiteSpace(fileName) || !Path.HasExtension(fileName))
        {
            string? contentType = response.Content.Headers.ContentType?.MediaType;
            string extension = UrlReader.GetExtensionFromContentType(contentType);
            fileName = string.IsNullOrWhiteSpace(fileName)
                ? $"file_{DateTime.Now:yyyyMMdd_HHmmss}{extension}"
                : fileName + extension;
        }

        string filePath = Path.Combine(directory, fileName);

        byte[] fileBytes = await response.Content.ReadAsByteArrayAsync(cancellationToken);
        await File.WriteAllBytesAsync(filePath, fileBytes, cancellationToken);

        Console.WriteLine($"File saved successfully: {filePath}");
    }
}
