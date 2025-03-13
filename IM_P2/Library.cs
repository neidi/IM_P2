namespace IM_P2;

public class Library
{
    private readonly List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public IEnumerable<Book> GetBooks()
    {
        return _books.ToList();
    }
}