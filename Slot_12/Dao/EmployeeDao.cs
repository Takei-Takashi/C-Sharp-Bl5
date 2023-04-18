using Slot_12.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_12.Dao
{
	public class EmployeeDao
	{
		public List<Employee> GetAllEmployees()
		{
			List<Employee> list = new List<Employee>();
			try
			{
				using (var context = new NorthwindContext())
				{
					return context.Employees.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
