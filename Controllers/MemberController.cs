using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers; // Folder names

public class MemberController : Controller
{
   public IActionResult Member1() //LocalHost/Member/Member1
   {
      var member1 = new Member // Instance of "Member" was created
      {
        Name = "Emily",
        Id = 001,
        CurrentBooksOnLoan = [
         new Book
         {
            Title = "Harry Potter and The Prisoner of Azkaban",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 10,
            NumOfCopiesOnLoan = 5
         }
        ],
        PastLoans = [
         new Book
         {
            Title = "Harry Potter and The Philosopher Stone",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 15,
            NumOfCopiesOnLoan = 10
         },
         new Book
         {
            Title = "Harry Potter and The Chamber of Secrets",
            Author = "J.K. Rowling",
            NumOfCopiesAvailable = 7,
            NumOfCopiesOnLoan = 3
         },
        ]
      };
      return View(member1); // This is what will be displayed, so we pass "member1"
   }

}