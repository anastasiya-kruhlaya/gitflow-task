using System.Text;

namespace Facade;

public class SimpleConverter(VideoConverter videoConverter)
{
    public SimpleConverter() : this(new VideoConverter())
    {
    }

    public string Convert(string filename, CodecFormat codecFormat)
    {
        var videoFile = new VideoFile(filename);

        Codec codec = codecFormat switch
        {
            CodecFormat.MPEG4 => new MPEG4Codec(),
            CodecFormat.OGG => new OGGCodec(),
            _ => throw new NotSupportedException($"Format '{codecFormat}' is not supported")
        };

        videoConverter.Convert(videoFile, codec);

        return GetOutputFile(filename, codecFormat);
    }

    public static string GetOutputFile(string filename, CodecFormat codecFormat)
    {
        return $"{Path.GetFileNameWithoutExtension(filename)}_converted.{codecFormat.ToString().ToLower()}";
    }
}
