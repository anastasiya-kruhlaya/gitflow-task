using AbstractFactory.ConcreteFactories;

namespace AbstractFactory;

class Program
{
    static void Main()
    {
        ChooseConfig(new EconomyCarFactory());
        ChooseConfig(new StandartCarFactory());
        ChooseConfig(new ExtraCarFactory());
    }

    public static void ChooseConfig(ICarFactory carFactory)
    {
        var engine = carFactory.CreateEngine();
        var suspension = carFactory.CreateSuspension();
        var wheelDiameter = carFactory.CreateWheelDiameter();

        engine.TypeOfEngine();
        suspension.TypeOfSuspension();
        wheelDiameter.TypeOfWheelDiameter();
    }
}

