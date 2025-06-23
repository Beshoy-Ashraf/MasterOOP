namespace OOP.CAExceptions;

public class Delivery
{
    public int id { get; set; }
    public string  name{ get; set; }
    public string  address{ get; set; }
    public DeliveryStatus status{get;set;}

    public Delivery(int id, string name, string address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        
    }

    public override string ToString()
    {
        return $"{{\n   Id: {id},\n   Customer: {name},\n   Address: {address},\n   Status: {status}\n}}";
 
    }
}