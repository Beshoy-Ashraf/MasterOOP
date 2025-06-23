namespace OOP.CAExceptions;

public class AccidentException : Exception
{
    public string Location { get; set; }

    public AccidentException(string message, string location) : base(message)
    {
        Location = location;
    }
    
}