using AbstractFactory.Interfaces;

namespace AbstractFactory.Models;

public class WheelDiameter(ConfigurationType configurationType) : IWheelDiameter
{
    public void PrintTypeOfWheelDiameter()
    {
        Console.WriteLine($"Your type of wheel diameter is {configurationType}");
    }
}
