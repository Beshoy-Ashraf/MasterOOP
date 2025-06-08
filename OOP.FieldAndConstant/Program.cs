using OPP.PrintClass;

namespace OOP.FieldAndConstant;

class Program
{
    private static PrintClass str = new PrintClass();
    static void Main(string[] args)
    {
        str.Print("Hello Dear enter numbers of Employee: ");
        var lenght = Convert.ToInt32(Console.ReadLine());
        Employee[] employees = new Employee[lenght];
        for (int i = 0; i < lenght; i++)
        {
            str.Print($"Employee {i+1} First Name:  " );
            var firstName = Console.ReadLine();
            str.Print($"Employee {i+1} Last Name:  " );
            var lastName = Console.ReadLine();
            str.Print($"Employee {i+1} Wage:  " );
            var wage = Convert.ToInt32(Console.ReadLine());
            str.Print($"Employee {i+1} LoggedHours:  " );
            var loggedHours = Convert.ToInt32(Console.ReadLine());
            employees[i] = new Employee(firstName, lastName, wage, loggedHours);
        }

        foreach (var employee in employees)
        {
            employee.PrintNetSalary();
        }
    }
}