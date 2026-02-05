using Facade;

class Program
{
    public static void Main(string[] args)
    {
        CarFacade carFacade = new CarFacade();
        carFacade.Start();
        carFacade.Accelerate();
        carFacade.Steer("left");
        carFacade.Stop();
    }
}