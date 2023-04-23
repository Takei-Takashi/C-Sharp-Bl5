using Demo_PE_Q2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PE_Q2.Dao
{
	public class EmployeeDao
	{
		public List<Employee> GetAllEmplpoyee()
		{
			try
			{
				using (var context = new PE_Fall21B5Context())
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
