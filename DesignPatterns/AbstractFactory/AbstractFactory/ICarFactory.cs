using AbstractFactory.AbstractObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ICarFactory
    {
        public abstract IEngine ChooseEngine();
        public abstract IWheelDiameter ChooseWheelDiameter();
        public abstract ISuspension ChooseSuspension();

    }
}
