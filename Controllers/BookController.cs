using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class BookController : Controller
{
   public IActionResult Book1() //LocalHost/Book/Book1
   {
      var book1 = new Book // Instance of "Book" was created
      {
        Title = "Harry Potter and the Philosopher Stone",
        Author = "J.K. Rowling",
        NumOfCopiesAvailable = 10,
        NumOfCopiesOnLoan = 5
      };
      return View(book1); // This is what will be displayed, so we pass "book1"
   }

    public IActionResult Book2()
   {
      var book2 = new Book
      {
        Title = "Harry Potter and the Chamber of Secrets",
        Author = "J.K. Rowling",
        NumOfCopiesAvailable = 15,
        NumOfCopiesOnLoan = 10
      };
      return View(book2);
   }

   public IActionResult Book3()
   {
      var book3 = new Book
      {
        Title = "Harry Potter and the Prisoner of Azkaban",
        Author = "J.K. Rowling",
        NumOfCopiesAvailable = 7,
        NumOfCopiesOnLoan = 3
      };
      return View(book3);
   }
}