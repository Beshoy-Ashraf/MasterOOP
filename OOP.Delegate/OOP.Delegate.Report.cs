namespace OOP.Delegate;

public class Report
{
    public delegate bool CondationBulider(Employee e);

    public void GetReport(Employee[] employee,String title,CondationBulider cond)
    {
        Console.WriteLine(title);
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        foreach (var e in employee)
        {
            if (cond(e))
                Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | {e.TotalSales}");
        }
        Console.WriteLine("_______________________________________________");
    }

    
}