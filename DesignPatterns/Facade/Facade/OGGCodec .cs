using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class OGGCodec:Codec
    {
        public string CodecName => "OGG";
        public OGGCodec()
        {
            Console.WriteLine("Initialized OGG");
        }
    }
}
