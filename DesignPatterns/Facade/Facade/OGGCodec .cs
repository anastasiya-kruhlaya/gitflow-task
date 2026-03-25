namespace Facade;

public class OGGCodec : Codec
{
    public CodecFormat CodecName => CodecFormat.OGG;
    
    public OGGCodec()
    {
        Console.WriteLine($"Initialized {CodecName}");
    }
}

