using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.ConcreteFactories;

public abstract class BaseCarFactory: ICarFactory
{
    public abstract ConfigurationType Type { get; }

    public IEngine CreateEngine()
    {
        return new Engine(Type);
    }

    public ISuspension CreateSuspension()
    {
        return new Suspension(Type);
    }

    public IWheelDiameter CreateWheelDiameter()
    {
        return new WheelDiameter(Type);
    }
}
