using AbstractFactory.Interfaces;

namespace AbstractFactory.Models;

public class Suspension(ConfigurationType configurationType) : ISuspension
{
    public void PrintTypeOfSuspension()
    {
        Console.WriteLine($"Your type of suspension is {configurationType}");
    }
}
