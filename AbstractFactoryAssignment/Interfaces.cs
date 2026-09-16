namespace AbstractFactoryAssignment
{
    public interface IVehicle
    {
        void ShowDetails();
    }

    public interface IEngine
    {
        void Start();
    }

    public interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateTruck();
        IEngine CreateEngine();
    }
}
