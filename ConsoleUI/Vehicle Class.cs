using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleUI;

public class Vehicle_Class : Vehicle
{
    public Vehicle_Class() : base()
    {
    }

    public override void DriveAbstract()
    {
        Console.WriteLine($"This {Year} {Make} {Model} is driving (abstract method).");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine($"This {Year} {Make} {Model} car is driving (virtual method overridden). ");
    }
}
