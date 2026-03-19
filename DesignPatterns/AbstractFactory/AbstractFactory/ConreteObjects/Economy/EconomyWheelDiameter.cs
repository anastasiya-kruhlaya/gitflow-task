using AbstractFactory.AbstractObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConreteObjects.Economy
{
    public class EconomyWheelDiameter:IWheelDiameter
    {
        public void TypeOfWheelDiameter()
        {
            Console.WriteLine("Your type of wheel diameter is economy");
        }
    }
}
