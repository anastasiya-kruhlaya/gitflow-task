using AsynchronousMethods;

class Program
{
    static async Task Main()
    {
        await FibCalculation.FibAsync();
        await FibCalculation.FibParallelAsync();
    }
}

