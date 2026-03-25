using AbstractFactory.Interfaces;

namespace AbstractFactory;

public interface ICarFactory : IHasType
{
    void PrintCarConfiguration();
}
