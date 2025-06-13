namespace OOP.Interface;

class Program
{
    static void Main(string[] args)
    {
        Cashier c = new Cashier(new Cash());
        c.Cashout(90000);
    }
}