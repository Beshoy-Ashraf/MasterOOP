namespace OOP.Generics;

class Program
{
    public delegate bool Filter<in T>(T o);
    static void Main(string[] args)
    {
        // var array = new Any<int>() ;
        // array.Add(1);
        // array.Add(2);
        // array.Add(3);
        // array.Add(4);
        // array.Remove(0);
        // array.print(); 
        
        IEnumerable<int> numbers = Enumerable.Range(1, 10);
        
        
        // PrintNumbers(numbers,n=> n > 5);
        PrintNumbers(numbers,n=> n % 2 == 0);
        
    }

     static void PrintNumbers<T>(IEnumerable<T> numbers, Predicate<T> filter)
    {

        foreach (var item in numbers)
        {
            if (filter(item))
            {
                Console.WriteLine(item);
            }
        }
    }
}