using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public bool HasTrunk { get; set; }

    public Car(string year, string make, string model, bool hasTrunk)
    {
        Year = year;
        Make = make;
        Model = model;
        HasTrunk = hasTrunk;
    }

    public override void DriveAbstract()
    {
        Console.WriteLine($"This {Year} {Make} {Model} car is driving (abstract method).");
    }
}