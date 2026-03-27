namespace Facade;

public class VideoConverter
{
    public VideoConverter()
    {
        Console.WriteLine("Initialized video converter");
    }

    public void Convert(VideoFile file, Codec codec)
    {
        Console.WriteLine($"Convert {file} to {codec.CodecName}");
    }
}

