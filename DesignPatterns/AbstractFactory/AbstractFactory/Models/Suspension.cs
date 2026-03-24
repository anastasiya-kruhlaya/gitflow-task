using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models;

public class Suspension(ConfigurationType configurationType) : ISuspension
{
    public void TypeOfSuspension()
    {
        Console.WriteLine($"Your type of suspension is {configurationType}");
    }
}
