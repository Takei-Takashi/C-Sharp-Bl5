using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            Book book = context.Books.Include(x => x.Authors).FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return View("Not found");
            }
            book.Authors.Clear();
            context.Books.Remove(book);
            context.SaveChanges();

            ViewBag.Books = context.Books.ToList();
            return RedirectToAction("List", "Book");
        }
    }
}
