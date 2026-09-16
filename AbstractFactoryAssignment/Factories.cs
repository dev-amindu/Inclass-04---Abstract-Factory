namespace AbstractFactoryAssignment
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new GasolineCar();
        }

        public IVehicle CreateTruck()
        {
            return new GasolineTruck();
        }

        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }
    }

    public class ElectricVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new ElectricCar();
        }

        public IVehicle CreateTruck()
        {
            return new ElectricTruck();
        }

        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
