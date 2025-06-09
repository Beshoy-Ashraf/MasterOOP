namespace OOP.NestedTypes;

public class Employee
{
    public int id{get;set;}
    public string name{get;set;}
    public Insurance insurance{get;set;}
    
    public Employee ()=>insurance =new Insurance{PolicyID = -1 ,CompanyName = "N/A"};

    public class  Insurance
    {
        public int PolicyID { get; set; }
        public String CompanyName { get; set; }
    }

}