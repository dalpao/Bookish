namespace Bookish.Models;

public class Member 
{
    public required string Name { get; set; }
    public required int Id { get; set; }
    public required List<Book> CurrentBooksOnLoan { get; set; }
    public required List<Book> PastLoans { get; set; }

}

