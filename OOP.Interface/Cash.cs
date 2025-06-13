namespace OOP.Interface;

public class Cash : Ipayment
{
    public void payment(decimal amount)
    {
        Console.WriteLine($"\n Cash payment: {amount}");
    }
}