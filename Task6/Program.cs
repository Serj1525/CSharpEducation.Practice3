namespace Task6;

class Program
{
    static void Main()
    {
        Distance distance = new Distance();
        distance.x=5;
        distance.y=5;
        distance.PrintDistance();
    }
}

struct Distance
{
    public int x;
    public int y;
    public void PrintDistance()
    {
        Console.WriteLine($"Расстояние между точками Х ({x}) и Y ({y}) равно {Math.Sqrt(x * x + y * y)}");
    }
} 
