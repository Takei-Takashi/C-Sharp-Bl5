using Microsoft.AspNetCore.Mvc;
using PRN211_Demo1_Q3.Models;

namespace PRN211_Demo1_Q3.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var context = new PRN211_Demo1Context();
            List<Book> books = context.Books.ToList();
            ViewBag.Books = books;
            return View();
        }
        public IActionResult Delete(int id)
        {
            var context = new PRN211_Demo1Context();
            Book book = context.Books.Find(id);
            if(book == null)
            {
                return View("Not found");
            }
            context.Books.Remove(book);
            context.SaveChanges();
            ViewBag.Books = context.Books.ToList();
            return RedirectToAction("List", "Book");
        }
    }
}
