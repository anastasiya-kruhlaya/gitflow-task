using AbstractFactory.AbstractObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConreteObjects.Standart
{
    public class StandartEngine:IEngine
    {
        public void TypeOfEngine()
        {
            Console.WriteLine("Your type of engine is standart.");

        }
    }
}
