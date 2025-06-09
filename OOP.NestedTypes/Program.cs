namespace OOP.NestedTypes;

class Program
{
    static void Main(string[] args)
    {
       Employee e = new Employee();
       Console.WriteLine(e.insurance.CompanyName);
    }
}