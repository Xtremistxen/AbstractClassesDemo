using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax
            var myCar = new Car("2024", "Toyota", "BZ4X",  true);

            var myMotorcycle = new Motorcycle("2020", "Kawasaki", "Cruiser",false);
            
            //explicit type
            Vehicle vehicle1 = new Car("2024", "Chevrolet","Sonic", true);
            Vehicle vehicle2 = new Motorcycle("2022", "Honda", "Grom", false);
            
            //list to hold all vehicles
            List<Vehicle> vehicles = new List<Vehicle>
            {
                myCar,
                myMotorcycle,
                vehicle1,
                vehicle2
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Type: {vehicle.GetType().Name}");
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make} Model: {vehicle.Model}");
                Console.WriteLine($"HasTrunk (if applicable): {(vehicle is Car ?((Car)vehicle).HasTrunk.ToString() : "N/A")}");
                Console.WriteLine($"HasSideCar (if applicable): {(vehicle is Motorcycle ? ((Motorcycle)vehicle).HasSideCar.ToString() : "N/A")}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }

            Console.ReadLine(); // keeps console open
            

            
            //Below is another method I wrote without syntax/explicte types
            //List<Vehicle> vehicles = new List<Vehicle>();

            // Car method
            //var myCar = new Vehicle_Class();

            //myCar.Year = "2024";
            //myCar.Make = "Toyota";
            //myCar.Model = "BZ4X";

            // Motorcycle method
            //var myMotorcycle = new Motorcycle();

            //myMotorcycle.Year = "2020";
            //myMotorcycle.Make = "Kawasaki";
            //myMotorcycle.Model = "Cruiser";
            
            //vehicles.Add(myCar);
            //vehicles.Add(myMotorcycle);

            //foreach (var vehicle in vehicles)
            {
                //vehicle.DriveAbstract();
                //vehicle.DriveVirtual();
                //Console.WriteLine();
            }
            
            //myCar.DriveAbstract();
            //myCar.DriveVirtual();
            
            //myMotorcycle.DriveAbstract();
            //myMotorcycle.DriveVirtual();
            
            

            #region Vehicles
            
            

            // Create a list of Vehicle called vehicles - DONE

            /* DONE
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *
             * Set the properties values with object initializer syntax
             */

            /* DONE
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle - DONE

            #endregion            
            Console.ReadLine();
        }
    }
}
