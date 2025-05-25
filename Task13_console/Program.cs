namespace Task13_console;

using System;
using Task13_lib;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        string sing = Console.ReadLine();
        MathHelper calc = new MathHelper();
        switch (sing)
        {
            case "+":
                Console.WriteLine($"{a}+{b}={calc.Addiction(a, b)}");
                break;
            case "-":
                Console.WriteLine($"{a}-{b}={calc.Subtraction(a, b)}");
                break;
            case "*":
                Console.WriteLine($"{a}*{b}={calc.Multiplication(a, b)}");
                break;
            case "/":
                Console.WriteLine($"{a}/{b}={calc.Division(a, b)}");
                break;
        }

    }
}