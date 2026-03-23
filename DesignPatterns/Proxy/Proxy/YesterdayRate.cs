using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class YesterdayRate:IYesterdayRate
    {
        public decimal GetRate()
        {
            Console.WriteLine("Request to external API");
            return 85.5m;
        }
    }
}
