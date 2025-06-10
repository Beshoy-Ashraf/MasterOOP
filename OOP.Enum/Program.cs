namespace OOP.Enum;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(Month.aug);
        Console.WriteLine((int)Month.aug);
        
        String M = "feb";
        // Console.WriteLine((int)System.Enum.Parse(typeof(Month), M));
        if (System.Enum.TryParse(M,out Month month))
        {
            Console.WriteLine((int)System.Enum.Parse(typeof(Month),month.ToString()));
        }

    }

    [Flags]
    enum Month
    {
        jan = 1,
        feb,
        mar,
        apr,
        may,
        jun,
        jul,
        aug,
        sep,
        oct,
        dec,
        nov,
    }

 
}