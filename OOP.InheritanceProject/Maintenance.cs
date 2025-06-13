namespace OOP.InheritanceProject;

public class Maintenance : Employee
{
    public const decimal hardShip = 100m;

    public Maintenance(int id, string name, decimal wage, decimal loggedHours): base(id, name, wage, loggedHours)
    {
        
    }

    protected override decimal Calculate()
    {
        return base.Calculate() + hardShip;
    }

    public override string ToString()
    {
        return base.ToString() +
               $"\nHardShip: {hardShip}" +
               $"\n NetSalary: {this.Calculate()}";
    }
}