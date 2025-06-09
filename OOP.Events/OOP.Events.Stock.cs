namespace OOP.Events;

public class Stock
{
     
    private String STName;
    private decimal STprice;
    public event Program.onPriceChange OnPriceChange;
    public String StockName => this.STName;
    public decimal StockPrice {get => this.STprice;set=>this.STprice=value;}

    public Stock(String name)
    {
        this.STName = name;
    }

    public void ChangeStockPrice(decimal newPrice)
    {
        decimal oldPrice = this.STprice;
        this.STprice += Math.Round(newPrice * this.STprice,2);
        if (OnPriceChange != null)
            OnPriceChange(this, oldPrice);
    }

}