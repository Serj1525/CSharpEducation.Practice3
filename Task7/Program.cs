using System.Diagnostics;

namespace Task7;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Какой месяц тебя интересует?");
        Month currentmonth = ParseMonth(Console.ReadLine());
        Console.WriteLine("А год?");
        int currentyear = int.Parse(Console.ReadLine());
        int days= DaysinMonth(currentmonth,currentyear);
        
        Console.WriteLine($"В месяце {currentmonth} {currentyear} года дней - {days}");
           
    }
    public enum Month
    {
        январь,
        февраль,
        март,
        апрель,
        май,
        июнь,
        июль,
        август,
        сентябрь,
        октябрь,
        ноябрь,
        декабрь
    }

    public static int DaysinMonth (Month month, int year)
    {
        switch(month)
        {
            case Month.январь:
            case Month.март:
            case Month.май:
            case Month.июль:
            case Month.август:
            case Month.октябрь:
            case Month.декабрь:    
                return 31;
            case Month.апрель:
            case Month.июнь:
            case Month.сентябрь:
            case Month.ноябрь:
                return 30;
            case Month.февраль:
                if (DateTime.IsLeapYear(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            default: 
                throw new ArgumentException("Недопустимый месяц");
        }
        
    }
    public static Month ParseMonth(string monthstring)
    {
        if (Enum.TryParse(monthstring, out Month month))
        {
            return month;
        }
        else
        {
            throw new ArgumentException("Неверно введено значение");
        }
    }
}