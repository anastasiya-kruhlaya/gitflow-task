namespace Proxy;

public class CachedYesterdayRate(IYesterdayRate realYesterdayRate) : IYesterdayRate
{
    private readonly IYesterdayRate _realYesterdayRate = realYesterdayRate;
    private decimal? _cachedRate;

    public CachedYesterdayRate() : this(new YesterdayRate())
    {
    }

    public decimal GetRate()
    {
        if (_cachedRate.HasValue)
        {
            Console.WriteLine("Return from cache");

            return _cachedRate.Value;
        }

        Console.WriteLine("Cache is null, making a request");
        _cachedRate = _realYesterdayRate.GetRate();

        return _cachedRate.Value;
    }
}

