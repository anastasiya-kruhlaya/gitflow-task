using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class VideoFile
    {
        private string _filename;
        public VideoFile(string filename)
        {
            _filename = filename;
        }
        public override string ToString()
        {
            return _filename;
        }
    }
}
