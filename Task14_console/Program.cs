namespace Task14_console;

using Task14_lib;
using System;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Зюся", 85);
        Person p2 = new Person("Зёся", 2);
        
        p1.PrintInfo();
        p2.PrintInfo();
        
    }
}