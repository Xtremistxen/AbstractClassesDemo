using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    public Vehicle()
    {
        Year = "YYYY";
        Make = "Make";
        Model = "Model";

    }

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine($" This {Year} {Make} {Model} is driving (virtual method).");
    }


}