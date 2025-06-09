namespace OOP.Properties;

public class Dollar
{
    private decimal _amount;
    //validation
    public decimal Amount
    {
        get
        {
            return _amount;
        }
        private set
        {
            _amount=ProcessValue(value);
        }
    }
    //protection 
    public decimal SetAmount(decimal amount)=>Amount=amount;
    //Constructor
    public Dollar(decimal amount)
    {
        _amount=ProcessValue(amount);
    }
    private decimal ProcessValue(decimal Value)=>Value<=0?0:Value; 
}