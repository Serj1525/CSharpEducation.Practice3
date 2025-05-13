namespace Task11;

static class Program
{
    public static void Main()
    {
        Book book1= new Book("Мумий Троль", "Тутта Ларсен");
        Book book2= new Book("Каратель", "Беркем Аль Атоми");
        Console.WriteLine(book1.bookout(book1));
        Console.WriteLine(book2.bookout(book2));
    }
    
}
public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public Book (string name, string author)
    {
        Name = name;
        Author = author;
    }
    public string bookout(Book book)
    {
        return $"Название книги: {book.Name}, автор:{book.Author}"; 
    }
}

