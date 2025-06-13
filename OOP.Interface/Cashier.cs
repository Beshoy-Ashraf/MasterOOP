namespace OOP.Interface;

public class Cashier 
{
    private Ipayment ipayment;

    public Cashier(Ipayment ipayment)
    {
        this.ipayment = ipayment;
        
    }

    public void Cashout(decimal amount)
    {
        ipayment.payment(amount);
    }
}