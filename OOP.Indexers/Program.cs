using OPP.PrintClass;

namespace OOP.Indexers;

class Program
{
    static void Main(string[] args)
    {
        // IP ip = new IP("192.168.1.1 ");
        // str.Print(ip.Address);
        // str.Print($"\nFirst segment is {ip[0]}");
        int[,] matrix = new int[,]
        {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        };
        Suduko s = new Suduko(matrix);
        s[5,5] = 1;
        str.Print(s[5,5].ToString());
            
    }
}