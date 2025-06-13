namespace OOP.Interface;

public class Visa : Ipayment
{
    public void payment(decimal amount)
    {
        Console.WriteLine($"\n visa payment: {amount}");
    }
}