using Proxy;

class Program
{
    static void Main()
    {

        IYesterdayRate rateService = new CachedYesterdayRate();

        decimal rate1 = rateService.GetRate();
        Console.WriteLine($"Exchange rate: {rate1}\n");

        decimal rate2 = rateService.GetRate();
        Console.WriteLine($"Exchange rate: {rate2}\n");
    }
}