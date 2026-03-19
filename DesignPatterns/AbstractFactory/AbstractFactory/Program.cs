
using AbstractFactory;
using AbstractFactory.ConcreteFactories;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            ChooseConfig(new EconomyFactory());
            ChooseConfig(new StandartFactory());
            ChooseConfig(new ExtraFactory());
        }
        public static void ChooseConfig(ICarFactory carFactory)
        {
            var engine = carFactory.ChooseEngine();
            var suspension = carFactory.ChooseSuspension();
            var wheelDiameter = carFactory.ChooseWheelDiameter();

            engine.TypeOfEngine();
            suspension.TypeOfSuspension();
            wheelDiameter.TypeOfWheelDiameter();

        }
    }
}
