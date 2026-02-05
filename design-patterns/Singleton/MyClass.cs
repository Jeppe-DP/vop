namespace Singleton;

public class MyClass

{
    public static MyClass _instance;
    private int _value;

    public MyClass(int value)
    {
        _value = value;
    }

    public static MyClass GetInstance(int value)
    {
        if (_instance == null)
        {
            _instance = new MyClass(10);
        }

        return _instance;
    }

    public void PrintValue()
    {
        Console.WriteLine("Value= "+ _value);
    }
}