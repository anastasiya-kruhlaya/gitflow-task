using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteFactories;

public class StandartCarFactory : BaseCarFactory
{
    public override ConfigurationType Type => ConfigurationType.Standart;
}

