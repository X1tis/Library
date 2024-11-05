public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }
    public string GetInfo()
    {
        return $"Title: {Title}, Author: {Author}, Pages: {Pages}";
    }
}

public class Library
{
    private List<Book> books;
    public Library()
    {
        books = new List<Book>();
    }
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }
    public void ShowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("There are no books in the library.");
        }
        else
        {
            Console.WriteLine("Available books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine(book.GetInfo());
            }
        }
    }
    public Book FindBook(string title)
    {
        foreach (var book in books)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book found: {book.GetInfo()}");
                return book;
            }
        }
        Console.WriteLine($"Book with title '{title}' not found.");
        return null;
    }
}
public class Program
{
    public static void Main()
    {
        Library library = new Library();
        Book book1 = new Book("War and Peace", "Leo Tolstoy", 1225);
        Book book2 = new Book("Crime and Punishment", "Fyodor Dostoevsky", 671);

        library.AddBook(book1);
        library.AddBook(book2);
        library.ShowBooks();
        string titleToSearch = "War and Peace";
        library.FindBook(titleToSearch);
    }
}

