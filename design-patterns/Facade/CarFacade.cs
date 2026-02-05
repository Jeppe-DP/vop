namespace Facade;

public class CarFacade
{
    public void Start() { Console.WriteLine("Engine started."); }
    public void Stop() { Console.WriteLine("Engine stopped."); }
    public void Accelerate() { Console.WriteLine("Engine Accelerated."); }
    public void Decelerate()
    {
        Console.WriteLine("Engine Decelerated.");
    }
    public void TurnLeft() { Console.WriteLine("Turning left."); }
    public void TurnRight() { Console.WriteLine("Turning right."); }
    public void Brake() { Console.WriteLine("Braking."); }

    public void Steer(string direction)
    {
        if (direction == "left")
            TurnLeft();
        else if (direction == "right")
            TurnRight();
    }
}