using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models;

public class WheelDiameter(ConfigurationType configurationType) : IWheelDiameter
{
    public void TypeOfWheelDiameter()
    {
        Console.WriteLine($"Your type of wheel diameter is {configurationType}");
    }
}
