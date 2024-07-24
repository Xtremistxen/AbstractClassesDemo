using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
   public bool HasSideCar { get; set; }

   public Motorcycle(string year, string make, string model, bool hasSideCar)
   {
      Year = year;
      Make = make;
      Model = model;
      HasSideCar = hasSideCar;
   }

   public override void DriveAbstract()
   {
      Console.WriteLine($"This {Year} {Make} {Model} motorcycle is driving (abstract method");
   }

   public override void DriveVirtual()
   {
      Console.WriteLine($"This {Year} {Make} {Model} motorcycle is driving (virtual method).");
   }
}