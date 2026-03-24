namespace Facade;

public class MPEG4Codec:Codec
{
    public string CodecName => "MPEG4";
    
    public MPEG4Codec()
    {
        Console.WriteLine("Initialized MPEG4");
    }
}

