namespace AsynchronousFileDownoload;

class Program
{
    static async Task Main()
    {
        using var cancellationToken = new CancellationTokenSource();

        Console.CancelKeyPress += (sender, e) =>
        {
            Console.WriteLine("\nCancel download");
            e.Cancel = true;
            cancellationToken.Cancel();
        };

        var urlList = UrlReader.ReadUrls();

        try
        {
            foreach (string url in urlList)
            {
                await FileDownloader.DownloadFileAsync(url, cancellationToken.Token);
            }
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operation for downoloading is cancelled");
        }
    }
}