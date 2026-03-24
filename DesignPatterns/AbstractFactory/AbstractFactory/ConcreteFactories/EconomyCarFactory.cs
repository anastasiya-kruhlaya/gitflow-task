using AbstractFactory.Interfaces;
using AbstractFactory.Models.Economy;

namespace AbstractFactory.ConcreteFactories;

public class EconomyCarFactory: BaseCarFactory
{
    public override ConfigurationType Type => ConfigurationType.Economy;

}

