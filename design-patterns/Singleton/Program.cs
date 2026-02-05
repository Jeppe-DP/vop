namespace Singleton;

class Program
{
    public static void Main(string[] args)
    {
        MyClass a = MyClass.GetInstance(10);

        a.PrintValue();
    }
}