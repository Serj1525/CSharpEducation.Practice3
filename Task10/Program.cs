namespace Task10;

static class Program
{
    public static void Main()
    {
        markoutput(new Auto("Audi"));
        markoutput(new Auto("BMW"));
    }
    public static void markoutput(Auto auto)
    {
        Console.WriteLine($"Марка: {auto.Mark}"); 
    }
}
public class Auto
{
    public string Mark { get; set; }
    public Auto(string mark)
    {
        Mark = mark;
    }
}