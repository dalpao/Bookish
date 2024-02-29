using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class CatalogueController : Controller
{
   public IActionResult Catalogue() //LocalHost/Book/Catalogue2024
   {
      var catalogue2024 = new Catalogue // Instance of "Book" was created
      {
         BookCatalogue = [
         new Book
         {
            Title = "Harry Potter and the Philosopher Stone",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 10,
            NumOfCopiesOnLoan = 5
         },
         new Book
         {
            Title = "Harry Potter and the Chamber of Secrets",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 15,
            NumOfCopiesOnLoan = 10
         },
         new Book
         {
            Title = "Harry Potter and the Prisoner of Azkaban",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 7,
            NumOfCopiesOnLoan = 3
         },
         ]
      };
      return View(catalogue2024); // This is what will be displayed, so we pass "catalogue2024"
   }
}