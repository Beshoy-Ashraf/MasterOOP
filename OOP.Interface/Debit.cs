namespace OOP.Interface;

public class Debit : Ipayment
{
    public void payment(decimal amount)
    {
        Console.WriteLine($"\n Debit payment: {amount}");
    }
}