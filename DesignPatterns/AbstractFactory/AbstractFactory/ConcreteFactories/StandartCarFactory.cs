using AbstractFactory.Interfaces;
using AbstractFactory.Models.Standart;

namespace AbstractFactory.ConcreteFactories;

public class StandartCarFactory: BaseCarFactory
{
    public override ConfigurationType Type => ConfigurationType.Standart;

}

