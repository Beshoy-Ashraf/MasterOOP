namespace OOP.InheritanceProject;

class Program
{
    static void Main(string[] args)
    {
        //Employee m = new Manger(1, "John", 176, 10);
        //Employee s = new Sales(1, "John", 176, 8,10000m,0.05m);
        // Employee ms = new Maintenance(1, "John", 9, 185);
        Employee d = new Developer(1, "John", 14, 180,true);
        
        
        Console.WriteLine(d);
    }
}