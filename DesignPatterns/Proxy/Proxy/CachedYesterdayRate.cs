namespace Proxy;

public class CachedYesterdayRate:IYesterdayRate
{
    private IYesterdayRate _realYesterdayRate;
    private decimal? _cachedRate;

    public CachedYesterdayRate()
    {
        _realYesterdayRate = new YesterdayRate(); 
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

