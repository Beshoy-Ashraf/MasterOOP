namespace OOP.Inheritance;

public class Eagle : Animal
{
    public void fly()
    {
        Console.WriteLine("Eagle Fly");
    }

    public override void Eat()
    {
        Console.WriteLine("Eagle Eat");
    }
}