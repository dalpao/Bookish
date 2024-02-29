namespace Bookish.Models;

public class Book 
{
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required int NumOfCopiesAvailable { get; set; }
    public required int NumOfCopiesOnLoan { get; set; }
}

