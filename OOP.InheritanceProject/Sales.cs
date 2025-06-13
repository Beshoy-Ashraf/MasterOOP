namespace OOP.InheritanceProject;

public class Sales:Employee
{
    private decimal salesRate{get;set;}
    private decimal commission{get;set;}

    public Sales(int id, string name, decimal wage, decimal loggedHours,decimal salesRate,decimal commission): base(id, name, wage, loggedHours)
    {
        this.salesRate = salesRate;
        this.commission = commission;
    }

    private decimal CalculateCommission()
    {
        return this.commission * this.salesRate;
    }

    protected override decimal Calculate()
    {
        return base.Calculate() + this.CalculateCommission();
    }

    public override string ToString()
    {
        return base.ToString()+
               $"\n commission: {this.CalculateCommission()}"+
               $"\n NetSalary: {this.Calculate()}";
            
    }
}