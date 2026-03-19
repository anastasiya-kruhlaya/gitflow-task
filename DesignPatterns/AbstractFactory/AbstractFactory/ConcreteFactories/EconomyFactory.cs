using AbstractFactory.AbstractObjects;
using AbstractFactory.ConreteObjects.Economy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories
{
    public class EconomyFactory:ICarFactory
    {
        public IEngine ChooseEngine()
        {
            return new EconomyEngine();
        }
        public ISuspension ChooseSuspension()
        {
            return new EconomySuspension();
        }

        public IWheelDiameter ChooseWheelDiameter()
        {
            return new EconomyWheelDiameter();
        }
    }
}
