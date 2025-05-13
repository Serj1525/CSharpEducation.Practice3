namespace Task4;

class Program
{
    static void Main()
    {
        Book defaultbook = new Book();
        Book maroder = new Book("Мародер","Беркем Аль Атоми");
        
        defaultbook.Printbook();
        maroder.Printbook();
    }
}

public class Book
{
    string name;
    string author;
    public Book() { name = "Без названия"; author = "Без автора"; } 
    public Book(string a, string b) { name = a; author = b; }
    public void Printbook()
    {
        Console.WriteLine($"Название книги: {name}. Автор: {author}");
    }
}

