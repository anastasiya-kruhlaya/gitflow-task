namespace Facade;

class Program
{
    static void Main()
    {
        var simpleConverter = new SimpleConverter();

        string mp4Result = simpleConverter.Convert("myvideo.avi", CodecFormat.MPEG4);
        Console.WriteLine($"Conversion complete: {mp4Result}\n");

        string oggResult = simpleConverter.Convert("anothervideo.mov", CodecFormat.OGG);
        Console.WriteLine($"Conversion complete: {oggResult}");
    }
}