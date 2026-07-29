using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03_LSP2
{

    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }
    public class EngineVehicle : Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting engine...");
        }
    }
    public class Car : EngineVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started...");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Bicycle is riding...");
        }
    }

    public class Program
    {
        public static void main(string[] args)
        {
            EngineVehicle vehicle1 = new Car();
            vehicle1.StartEngine();
            vehicle1.Drive();

            Vehicle vehicle2 = new Bicycle();
            vehicle2.Drive();        // Behaves as expected for a bicycle.
        }
    }

}
