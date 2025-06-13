namespace OOP.InheritanceProject;

public class Developer: Employee
{
    private const decimal bouns = 0.03m;
    private bool taskCompleted {get; set;}

    public Developer(int id, string name, decimal wage, decimal loggedHours,bool taskCompleted): base(id, name, wage, loggedHours)
    {
        this.taskCompleted = taskCompleted;   
    }

    private decimal CalculateBouns()
    {
        return bouns * base.Calculate();
    }

    protected override decimal Calculate()
    {
        return base.Calculate()+ CalculateBouns();
    }

    public override string ToString()
    {
        return base.ToString() +
               $"\nbonus: {CalculateBouns()}" +
               $"\ntask completed: {taskCompleted}" +
               $"\nNetSalary: {this.Calculate()}";
    }
}