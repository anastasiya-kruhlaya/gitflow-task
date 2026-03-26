namespace Facade;

public class OGGCodec : Codec
{
    public override CodecFormat CodecName => CodecFormat.OGG;
    
    public OGGCodec()
    {
        Console.WriteLine($"Initialized {CodecName}");
    }
}

