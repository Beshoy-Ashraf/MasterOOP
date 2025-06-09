namespace OOP.Events;

public class Program
{
    static void Main(string[] args)
    {
        Stock st = new Stock("GOLD");
        st.StockPrice = 100m;
        st.OnPriceChange += StockPriceChange;
        st.ChangeStockPrice(0.012m);
        st.ChangeStockPrice(-0.012m);
        st.ChangeStockPrice(0.012m);
        st.ChangeStockPrice(0.00m);
        

    }

    private static void StockPriceChange(Stock stock, decimal oldprice)
    {
        if (stock.StockPrice > oldprice)
            Console.ForegroundColor = ConsoleColor.Green;
        else if (stock.StockPrice < oldprice)
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{stock.StockName} | new price is: {stock.StockPrice} | old price is: {oldprice}");
    }   



    public delegate void onPriceChange(Stock stock, decimal oldprice);
}