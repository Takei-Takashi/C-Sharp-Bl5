using Slot_12.Models;
using System;
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
					list = context.Employees.ToList();
				}
			}
			catch (Exception)
			{
			}
			return list;
		}
	}
}
