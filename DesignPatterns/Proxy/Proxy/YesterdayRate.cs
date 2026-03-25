namespace Proxy;

public class YesterdayRate : IYesterdayRate
{
    public decimal GetRate()
    {
        Console.WriteLine("Request to external API");

        return 85.5m;
    }
}

