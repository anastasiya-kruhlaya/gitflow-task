using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteFactories;

public class ExtraCarFactory : BaseCarFactory
{
    public override ConfigurationType Type => ConfigurationType.Extra;
}

