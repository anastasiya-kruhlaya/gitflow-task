namespace AsynchronousMethods;

public class FibCalculation
{
    private const int i = 3;

    public static async Task FibAsync()
    {
        int[] results = new int[i];
        for (int k = 0; k < i; k++)
        {
            results[k] = await Task.Run(() => Fib(k));
        }

        Console.WriteLine(string.Join(", ", results));
    }

    public static async Task FibParallelAsync()
    {
        Task<int>[] tasks = new Task<int>[i];

        for (int k = 0; k < i; k++)
        {
            var index = k;
            tasks[index] = Task.Run(() => Fib(index));
        }
        int[] results = await Task.WhenAll(tasks);

        Console.WriteLine(string.Join(", ", results));
    }

    public static int Fib(int i)
    {
        if(i <= 1)
        {

            return i;
        }

        return Fib(i - 1) + Fib(i - 2);
    }
}
