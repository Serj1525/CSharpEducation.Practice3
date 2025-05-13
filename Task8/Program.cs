namespace Task8;

class Program
{
    static void Main()
    {
        Square square = new Square();
        square.x=5.25;
        square.y=5.35;
        square.square();
    }
}

struct Square
{
    public double x;
    public double y;
    public void square()
    {
        Console.WriteLine($"Площадь прямоугольника длиной {x} мм и шириной {y} мм равна {x * y} мм^2");
    }
} 
