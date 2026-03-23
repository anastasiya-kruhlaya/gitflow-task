using AbstractFactory.AbstractObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConreteObjects.Standart
{
    public class StandartSuspension:ISuspension
    {
        public void TypeOfSuspension()
        {
            Console.WriteLine("Your type of suspension is standart");
        }
    }
}
