using OPP.PrintClass;

namespace OOP.Properties;

class Program
{
    static void Main(string[] args)
    {
        Dollar dollar = new Dollar(1.99m);
        //dollar.Amount = 1.99;
        dollar.SetAmount(1.0m);
        str.Print(dollar.Amount.ToString());

    }
}