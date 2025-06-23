namespace OOP.CAExceptions;

class Program
{
    static void Main(string[] args)
    {
        var delivery = new Delivery(123, "Besho", "22amryiaAlex");
        var service = new DeliveryService();
        service.Start(delivery);
        Console.WriteLine(delivery);
    }
}