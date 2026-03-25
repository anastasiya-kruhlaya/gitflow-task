using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.ConcreteFactories;

public abstract class BaseCarFactory : ICarFactory
{
    public abstract ConfigurationType Type { get; }

    protected IEngine CreateEngine()
    {
        return new Engine(Type);
    }

    protected ISuspension CreateSuspension()
    {
        return new Suspension(Type);
    }

    protected IWheelDiameter CreateWheelDiameter()
    {
        return new WheelDiameter(Type);
    }

    public void PrintCarConfiguration()
    {
        var engine = CreateEngine();
        var suspension = CreateSuspension();
        var wheelDiameter = CreateWheelDiameter();

        engine.PrintTypeOfEngine();
        suspension.PrintTypeOfSuspension();
        wheelDiameter.PrintTypeOfWheelDiameter();
    }
}
