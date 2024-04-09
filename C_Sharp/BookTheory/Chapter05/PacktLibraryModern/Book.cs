using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Packt.Shared;

public class Book
{
    // Constructor for use with object initializer syntax.
    public Book()
    { }

    // Constructor with parameters to set required fields.
    [SetsRequiredMembers]
    public Book(string isbn, string title)
    {
    }

    public string? Author;
    public int PageCount;
}