namespace Task2;

using System;

class Program
{
    static void Main()
    {
        Student student = new Student();
        //student.RatingMid = double.Parse(Console.ReadLine());
        Console.WriteLine($"Имя - {student.Name}, возраст - {student.Age}, средняя оценка - {student.RatingMid}");
        student.RatingMid = 4;
        Console.WriteLine($"Имя - {student.Name}, возраст - {student.Age}, средняя оценка - {student.RatingMid}");
        student.RatingMid = -12;
        Console.WriteLine($"Имя - {student.Name}, возраст - {student.Age}, средняя оценка - {student.RatingMid}");

    }
    
}
public class Student
{
    public string Name="хуй собачий";
    public int Age=32;
    int rating=0;
    public int RatingMid
    {
        set
        {
            if (value < 0 || value > 5)
                Console.WriteLine("Балл указан неверно (0-5), дубина");
            else rating = value;
        }
        get { return rating; }
    }
}