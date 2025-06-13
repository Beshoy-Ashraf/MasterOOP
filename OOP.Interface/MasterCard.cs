namespace OOP.Interface;

public class MasterCard : Ipayment
{
    public void payment(decimal amount)
    {
        Console.WriteLine($"\n MasterCard payment: {amount}");
    }
}