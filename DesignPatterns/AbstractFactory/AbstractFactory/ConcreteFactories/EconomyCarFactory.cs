using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteFactories;

public class EconomyCarFactory : BaseCarFactory
{
    public override ConfigurationType Type => ConfigurationType.Economy;
}

