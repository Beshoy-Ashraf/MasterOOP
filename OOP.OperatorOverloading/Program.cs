using OPP.PrintClass;

namespace OOP.OperatorOverloading;

class Program
{
    static void Main(string[] args)
    {
        Money m1 = new Money(10);
        Money m2 = new Money(20);
        Money m3 = new Money(30);
        Money m4 = m1+m2;
        m2--;
        Console.WriteLine($"{m2.Amount}");
    }
}