namespace Task14_lib;

public class Person
{
    public string Name {get; set;}
    public int Age {get; set;}

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя - {Name}, возраст - {Age}");
    }
}