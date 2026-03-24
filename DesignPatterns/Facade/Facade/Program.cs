namespace Facade;

class Program
{
    static void Main()
    {
        var simpleConverter = new SimpleConverter();

        string result1 = simpleConverter.Convert("myvideo.avi", "MP4");
        Console.WriteLine($"Conversion complete: {result1}\n");

        string result2 = simpleConverter.Convert("anothervideo.mov", "OGG");
        Console.WriteLine($"Conversion complete: {result2}");
    }
}