using AbstractFactory.Interfaces;

namespace AbstractFactory;
public interface ICarFactory: IHasType
{
    IEngine CreateEngine();
    IWheelDiameter CreateWheelDiameter();
    ISuspension CreateSuspension();
}
