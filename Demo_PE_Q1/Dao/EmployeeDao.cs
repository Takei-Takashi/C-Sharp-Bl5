using Demo_PE_Q1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PE_Q1.Dao
{
	public class EmployeeDao
	{
		public List<Employee> GetAllEmployee()
		{
			try
			{
				using(var context = new PE_Fall21B5Context())
				{
					return context.Employees.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public List<Employee> GetAllEmployeeWithDepartment()
		{
			using (var context = new PE_Fall21B5Context())
			{
				return context.Employees.Include(e => e.DepartmentNavigation).ToList();
			}
		}
		public List<EmployeeWithDepartment> GetEmployeeWithDepartments()
		{
			try
			{
				using (var context = new PE_Fall21B5Context())
				{
					var employeeWithDepartment = from e in context.Employees
												 join d in context.Departments
												 on e.Department equals d.Id
												 where d.Name != null
												 select new EmployeeWithDepartment
												 {
													 Id = e.Id,
													 Name = e.Name,
													 Dob = e.Dob,
													 Sex = e.Sex,
													 Position = e.Position,
													 Department = e.Department,
													 DepartmentName = d.Name
												 };
					return employeeWithDepartment.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
