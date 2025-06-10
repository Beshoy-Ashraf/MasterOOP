namespace OOP.Inheritance;
// sealed meaning don't allow inheritance principle  
public sealed class Falcon : Animal
{
    public  void Fly()
    {
        Console.WriteLine("Falcon Fly");
    }

    public sealed override void Eat()
    {
        Console.WriteLine("Falcon Eat");
    }

    public override string ToString()
    {
        return base.ToString();
    }
}