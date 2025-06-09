namespace OOP.Delegate;

class Program
{
    static void Main(string[] args)
    {
        var emps = new Employee[]
        {
            new Employee { Id = 1, Name = "Beshoy", Gender = "M", TotalSales = 50000m },
            new Employee { Id = 2, Name = "Ashraf", Gender = "M", TotalSales = 60000m },
            new Employee { Id = 3, Name = "Agib", Gender = "M", TotalSales = 40000m },
            new Employee { Id = 4, Name = "Atyatulla", Gender = "M", TotalSales = 20000m },
            new Employee { Id = 5, Name = "Ali", Gender = "M", TotalSales = 10000m },
            new Employee { Id = 6, Name = "Mamdouh", Gender = "M", TotalSales = 5000m },
            new Employee { Id = 7, Name = "Osama", Gender = "M", TotalSales = 25000m },
            new Employee { Id = 8, Name = "Mostafa", Gender = "M", TotalSales = 800000m },
        };
        var report = new Report();
        report.GetReport(emps,"Employees over than or equal 60000",(e)=>e.TotalSales>=60000m);
        report.GetReport(emps,"Employees over than or equal 30000 and less than 60000",(e)=>e.TotalSales>=30000m && e.TotalSales<=60000m );
        report.GetReport(emps,"Employees less than 30000",(e)=>e.TotalSales<30000m  );
        
    }
}