using AbstractFactory.AbstractObjects;
using AbstractFactory.ConreteObjects.Economy;
using AbstractFactory.ConreteObjects.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories
{
    public class StandartFactory:ICarFactory
    {
        public IEngine ChooseEngine()
        {
            return new StandartEngine();
        }
        public ISuspension ChooseSuspension()
        {
            return new StandartSuspension();
        }

        public IWheelDiameter ChooseWheelDiameter()
        {
            return new StandartWheelDiameter();
        }
    }
}
