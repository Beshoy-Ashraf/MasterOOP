namespace OOP.InheritanceProject;

public class Employee
{
    protected int id{get; set; }
    protected string name{get; set; }
    protected decimal wage{get; set; }
    protected decimal loggedHours{get; set; }
    protected const decimal MiniHours = 176;
    protected const decimal OverTime = 1.25m;

    protected Employee(int id, string name, decimal wage, decimal loggedHours)
    {
        this.id = id;
        this.name = name;
        this.wage = wage;
        this.loggedHours = loggedHours;
    }

    protected decimal CalculateBaseSalary()
    {
        decimal hoursRate = Math.Min(this.loggedHours, MiniHours);
        return   hoursRate * this.wage;
    }

    protected decimal CalculateOverTime()
    {
        decimal overTimeHours = (loggedHours > MiniHours)?loggedHours - MiniHours:0 ;
        return overTimeHours * this.wage * OverTime;
    }

    protected virtual decimal Calculate()
    {
        return this.CalculateBaseSalary()+this.CalculateOverTime();
    }

    public override string ToString()
    {
        var type = this.GetType().ToString().Replace("OOP.InheritanceProject.","");
        return $"{type}"+
               $"\nid: {this.id}"+
               $"\nName: {this.name}"+
               $"\nWage: {this.wage}"+
               $"\nloggedHours: {this.loggedHours}"+
               $"\noverTime: {this.CalculateOverTime()}"+
               $"\nbaseSalary: {this.CalculateBaseSalary()}";
               ;
    }
}