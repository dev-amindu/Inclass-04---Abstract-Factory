using System;

namespace AbstractFactoryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Vehicle Manufacturing System ===\n");

            // Scenario 1: Manufacturing Gasoline Vehicles
            Console.WriteLine("--- Ordering from Gasoline Factory ---");
            IVehicleFactory gasolineFactory = new GasolineVehicleFactory();
            ManufactureAndShowcase(gasolineFactory);

            Console.WriteLine();

            // Scenario 2: Manufacturing Electric Vehicles
            Console.WriteLine("--- Ordering from Electric Factory ---");
            IVehicleFactory electricFactory = new ElectricVehicleFactory();
            ManufactureAndShowcase(electricFactory);
        }

        static void ManufactureAndShowcase(IVehicleFactory factory)
        {
            // Create products using the factory
            IVehicle car = factory.CreateCar();
            IVehicle truck = factory.CreateTruck();
            IEngine engine = factory.CreateEngine();

            // Use the products
            engine.Start();
            car.ShowDetails();
            truck.ShowDetails();
        }
    }
}
