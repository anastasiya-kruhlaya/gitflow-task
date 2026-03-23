using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SimpleConverter
    {
        private readonly VideoConverter _videoConverter;
        public SimpleConverter()
        {
            _videoConverter = new VideoConverter();
        } 

        public string Convert(string filename, string format)
        {
            var videoFile = new VideoFile(filename);

            Codec codec = format.ToUpper() switch
            {
                "MP4" => new MPEG4Codec(),
                "OGG" => new OGGCodec(),
                _ => throw new NotSupportedException($"Format '{format}' is not supported")
            };

            _videoConverter.Convert(videoFile, codec);

            string outputFilename = Path.GetFileNameWithoutExtension(filename) +
                                    $"_converted.{format.ToLower()}";
            return outputFilename;
        }
    }
}
