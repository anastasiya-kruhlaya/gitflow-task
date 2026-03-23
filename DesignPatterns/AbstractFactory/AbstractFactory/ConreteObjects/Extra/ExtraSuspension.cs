using AbstractFactory.AbstractObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConreteObjects.Extra
{
    public class ExtraSuspension:ISuspension
    {
        public void TypeOfSuspension()
        {
            Console.WriteLine("Your type of suspension is extra");
        }
    }
}
