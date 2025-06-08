namespace OOP.FieldAndConstant;

public class Employee
{
    private const Double TAX=0.03;
    private String Fname;
    private String Lname;
    private int Wage;
    private int LoggedHours;

    public  Employee(String FirstName, String LastName, int EmployeeWage, int EmployeeLoggedHours)
    {
        this.Fname = FirstName;
        this.Lname = LastName;
        this.Wage = EmployeeWage;
        this.LoggedHours = EmployeeLoggedHours;
    }

    public void PrintNetSalary()
    {
        Console.WriteLine($"Employee First name is:  {this.Fname} ");
        Console.WriteLine($"Employee Last name is:  {this.Lname} ");
        var netsalary = this.LoggedHours *this.Wage-(this.LoggedHours *this.Wage* TAX);
        Console.WriteLine($"Employee Net Salary is:  {netsalary} ");
    }
}