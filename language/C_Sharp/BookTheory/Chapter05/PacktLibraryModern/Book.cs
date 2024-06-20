using System.Diagnostics.CodeAnalysis;

namespace Packt.Shared;

public class Book
{
    public string Isbn;
    public string Title;

    // Constructor for use with object initializer syntax.
    public Book()
    { }

    // Constructor with parameters to set required fields.
    [SetsRequiredMembers]
    public Book(string isbn, string title)
    {
        Isbn = isbn;
        Title = title;
    }

    public string? Author;
    public int PageCount;
}