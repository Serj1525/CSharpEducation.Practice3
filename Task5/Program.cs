namespace Task5;

class Program
{
    static void Main()
    {
        Book defaultbook = new Book();
        Book witcher = new Book("Вьедьмин");
        Book maroder = new Book("Мародер","Беркем Аль Атоми");
        Book harrypotter = new Book("Гарик Потер","Женя Крутилка",2000);
        
        defaultbook.Printbook();
        witcher.Printbook();
        maroder.Printbook();
        harrypotter.Printbook();
    }
}
public class Book
{
    string name;
    string author;
    int year;
    public Book() { name = "Без названия";
        author = "Без автора";
        year = 0;
    } 
    public Book(string a) { name = a;}
    public Book(string a, string b) { name = a; author = b; }
    public Book(string a, string b, int c) { name = a; author = b; year = c; }
    public void Printbook()
    {
        Console.WriteLine($"Название книги: {name}. Автор: {author}. Год издания: {year}");
    }
}