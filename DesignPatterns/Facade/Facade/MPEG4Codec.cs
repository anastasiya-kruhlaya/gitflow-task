using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class MPEG4Codec:Codec
    {
        public string CodecName => "MPEG4";
        public MPEG4Codec()
        {
            Console.WriteLine("Initialized MPEG4");
        }
    }
}
