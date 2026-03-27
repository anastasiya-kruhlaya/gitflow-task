using AbstractFactory.ConcreteFactories;

namespace AbstractFactory;

class Program
{
    static void Main()
    {
        var economyFactory = new EconomyCarFactory();
        economyFactory.PrintCarConfiguration();
        var standartFactory = new StandartCarFactory();
        standartFactory.PrintCarConfiguration();
        var extraFactory = new ExtraCarFactory();
        extraFactory.PrintCarConfiguration();
    }
}

