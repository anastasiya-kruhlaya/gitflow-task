using AbstractFactory.Interfaces;

namespace AbstractFactory.Models;

public class Engine(ConfigurationType configurationType) : IEngine
{
    public void PrintTypeOfEngine()
    {
        Console.WriteLine($"Your type of engine is {configurationType}");
    }
}

