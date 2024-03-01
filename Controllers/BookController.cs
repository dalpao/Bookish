using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class BookController : Controller
{
   [HttpGet("[controller]/{id}")]
   public IActionResult Book([FromRoute] int id) //LocalHost/Book/1
   {
     Book book;

        switch (id)
        {
            case 1:
                book = new Book
                {
                    Title = "Harry Potter and the Philosopher's Stone",
                    Author = "J.K. Rowling",
                    NumOfCopiesAvailable = 10,
                    NumOfCopiesOnLoan = 5
                };
                break;
            case 2:
                book = new Book
                {
                    Title = "Harry Potter and the Chamber of Secrets",
                    Author = "J.K. Rowling",
                    NumOfCopiesAvailable = 15,
                    NumOfCopiesOnLoan = 10
                };
                break;
            case 3:
                book = new Book
                {
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Author = "J.K. Rowling",
                    NumOfCopiesAvailable = 7,
                    NumOfCopiesOnLoan = 3
                };
                break;
            default:
                return NotFound();
        }

      return View(book);
   }
}