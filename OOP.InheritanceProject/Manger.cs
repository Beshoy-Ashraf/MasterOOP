namespace OOP.InheritanceProject;

public class Manger: Employee
{
    private const decimal AllowanceRate = 0.05m;

    public Manger(int id, string name, decimal wage, decimal loggedHours): base(id, name, wage, loggedHours)
    {
        
    }
    
    private decimal GetAllowance()
    {
        return AllowanceRate*base.Calculate();
    }

    protected override decimal Calculate()
    {
        return GetAllowance()+base.Calculate();
    }

    public override string ToString()
    {
        return base.ToString()+
               $"\nAllowance: {this.GetAllowance()}" +
               $"\nNetSalary: {this.Calculate()}"
               ;
    }
}