namespace IM_P2;

public class Book
{
    private readonly string _title;
    private readonly string _author;
    private readonly DateOnly _publishedDate;

    public Book(string title, string author, DateOnly publishedDate)
    {
        _title = title;
        _author = author;
        _publishedDate = publishedDate;
    }

    public override string ToString()
    {
        return $"""
                Title: {_title}
                Author: {_author}
                Published Date: {_publishedDate:dd.MM.yyyy}
                """;
    }
}