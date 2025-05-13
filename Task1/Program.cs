namespace Task1;

using System;

class Program
{
    static void Main()
    {
       Student student = new Student();
       Console.WriteLine($"Имя - {student.Name}, возраст - {student.Age}");

    }
}
public class Student
{
    public string Name="wqerty";
    public int Age=32;
    
}