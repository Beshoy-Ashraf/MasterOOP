namespace OOP.OperatorOverloading;

public class Money
{
    private decimal _amount;

    public decimal Amount
    {
        get => _amount;
        private set => _amount = value;
    }

    public Money(decimal amount)
    {
        _amount = amount;
    }

    public static Money operator +(Money a, Money b) => new Money(a.Amount + b.Amount);
    public static Money operator -(Money a, Money b) => new Money(a.Amount - b.Amount);
    public static Money operator *(Money a, Money b) => new Money(a.Amount * b.Amount);
    public static Money operator /(Money a, Money b) => new Money(a.Amount / b.Amount);

    public static bool operator <(Money a, Money b) => a.Amount < b.Amount;
    public static bool operator >(Money a, Money b) => a.Amount > b.Amount;
    public static bool operator <=(Money a, Money b) => a.Amount <= b.Amount;
    public static bool operator >=(Money a, Money b) => a.Amount >= b.Amount;

    public static Money operator ++(Money a) => new Money((++a.Amount));
    public static Money operator --(Money a) => new Money((--a.Amount));

    // public static Money operator ++(Money money)
    // {
    //     var value = money.Amount;
    //     return new Money(++value);
    // }
    //
    // public static Money operator --(Money money)
    // {
    //     var value = money.Amount;
    //     return new Money(--value);
    // }

    public static bool operator ==(Money a, Money b) => a.Amount == b.Amount;
    public static bool operator !=(Money a, Money b) => a.Amount == b.Amount;


}