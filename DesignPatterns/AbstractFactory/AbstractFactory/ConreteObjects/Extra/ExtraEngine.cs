using AbstractFactory.AbstractObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConreteObjects.Extra
{
    public class ExtraEngine:IEngine
    {
        public void TypeOfEngine()
        {
            Console.WriteLine("Your type of engine is extra.");

        }
    }
}
