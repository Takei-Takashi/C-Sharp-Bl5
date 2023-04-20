using Microsoft.AspNetCore.Mvc;
using Slot_19.Models;

namespace Slot_19.Controllers
{
	public class ProductController : Controller
	{
		public Function f = new Function();
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult List()
		{
			var context = new NorthwindContext();
			List<Category> categories = context.Categories.ToList();
			ViewBag.Categories = categories;
			return View();
		}
		[HttpPost]
		public ActionResult List(int cateId, int discontinued)
		{
			var context = new NorthwindContext();
			List<Category> categories = context.Categories.ToList();
			ViewBag.Categories = categories;
			List<Product> products = context.Products.ToList();
			List<Product> productList = f.GetProducts(cateId, discontinued, products);
			ViewBag.Products = productList;
			return View();
		}
	}
}
