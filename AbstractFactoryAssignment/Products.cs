using System;

namespace AbstractFactoryAssignment
{
    // --- Gasoline Products ---
    public class GasolineCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle Type: Gasoline Car");
        }
    }

    public class GasolineTruck : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle Type: Gasoline Truck");
        }
    }

    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline Engine started: Vroom vroom!");
        }
    }

    // --- Electric Products ---
    public class ElectricCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle Type: Electric Car");
        }
    }

    public class ElectricTruck : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle Type: Electric Truck");
        }
    }

    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric Engine started: Silent hum...");
        }
    }
}
