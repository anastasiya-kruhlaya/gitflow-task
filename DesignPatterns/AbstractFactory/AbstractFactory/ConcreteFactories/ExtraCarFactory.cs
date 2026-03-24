using AbstractFactory.Interfaces;
using AbstractFactory.Models.Extra;

namespace AbstractFactory.ConcreteFactories;

public class ExtraCarFactory: BaseCarFactory
{
    public override ConfigurationType Type => ConfigurationType.Extra;

}

