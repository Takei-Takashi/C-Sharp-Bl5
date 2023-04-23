using Demo_PE_Q3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_PE_Q3.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult List()
		{
			var context = new PE_Fall21B5Context();
			List<Employee> employees = context.Employees.ToList();
			ViewBag.Employees = employees;
			return View();
		}
		public IActionResult Delete(int id)
		{
			var context = new PE_Fall21B5Context();
			Employee employee = context.Employees.Find(id);
			if(employee == null)
			{
				return View("Not found");
			}
			context.Employees.Remove(employee);
			context.SaveChanges();
			ViewBag.Employee = context.Employees.ToList();
			return RedirectToAction("List", "Employee");
		}
	}
}
