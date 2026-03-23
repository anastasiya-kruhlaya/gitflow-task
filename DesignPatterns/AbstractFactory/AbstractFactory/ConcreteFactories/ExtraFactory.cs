using AbstractFactory.AbstractObjects;
using AbstractFactory.ConreteObjects.Economy;
using AbstractFactory.ConreteObjects.Extra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories
{
    public class ExtraFactory:ICarFactory
    {
        public IEngine ChooseEngine()
        {
            return new ExtraEngine();
        }
        public ISuspension ChooseSuspension()
        {
            return new ExtraSuspension();
        }

        public IWheelDiameter ChooseWheelDiameter()
        {
            return new ExtraWheelDiameter();
        }
    }
}
