using System.ComponentModel.DataAnnotations;

namespace Packt.Shared;

public class Book
{
    public string? Isbn;
    public string? Title;

    public string? Author;
    public int PageCount;
}