namespace Facade;

public class MPEG4Codec : Codec
{
    public override CodecFormat CodecName => CodecFormat.MPEG4;
    
    public MPEG4Codec()
    {
        Console.WriteLine($"Initialized {CodecName}");
    }
}

