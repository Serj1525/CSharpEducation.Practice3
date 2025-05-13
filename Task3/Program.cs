namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        string sing = Console.ReadLine();
        Calculator calc= new Calculator();
        switch (sing)
        {
            case "+":
                Console.WriteLine($"{a}+{b}={calc.Addiction(a,b)}");
                break;
            case "-":
                Console.WriteLine($"{a}-{b}={calc.Subtraction(a,b)}");
                break;
            case "*":
                Console.WriteLine($"{a}*{b}={calc.Multiplication(a,b)}");
                break;
            case "/":
                Console.WriteLine($"{a}/{b}={calc.Division(a,b)}");
                break;
        }
    }
    public class Calculator
    {
        public int Addiction(int a, int b)
        {
           return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            return a/b;
        }
    }
}