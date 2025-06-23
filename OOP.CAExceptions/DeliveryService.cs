namespace OOP.CAExceptions;

public class DeliveryService{

    private readonly static Random random = new Random();
    public void Start(Delivery delivery)
    {
        try
        {

            process(delivery);
            Shipped(delivery);
            intransit(delivery);
            deliver(delivery);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Deliver faiid due to {ex.Message}");
            delivery.status = DeliveryStatus.UNKNOWN;
        }
        
    }

    private void process(Delivery delivery)
    {
        FakeIt("Processing");
        delivery.status = DeliveryStatus.PROCESSED;
    }

    private void Shipped(Delivery delivery)
    {
        FakeIt("Shipped");
        delivery.status = DeliveryStatus.SHIPPED;
        
    }

    private void intransit(Delivery delivery)
    {
        FakeIt("Intransit");
        if (random.Next(1, 5) == 1)
        {
            throw new AccidentException("Accident exception","332 some another street");
        }
        delivery.status = DeliveryStatus.INTRANSIT;
    }

    private void deliver(Delivery delivery)
    {
        FakeIt("Delivered");
        if (random.Next(1, 5) == 1)
        {
            throw new AddressException($"address{delivery.address} is INVALID");
        }
        delivery.status = DeliveryStatus.DELIVERED;
    }


    private void FakeIt(String title)
    {
        Console.Write(title);
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.Write(".");
        System.Threading.Thread.Sleep(300);
        Console.WriteLine(".");
    }
}