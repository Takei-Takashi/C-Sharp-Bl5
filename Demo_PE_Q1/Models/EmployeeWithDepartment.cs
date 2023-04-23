using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PE_Q1.Models
{
	public partial class EmployeeWithDepartment
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public DateTime Dob { get; set; }
		public string? Sex { get; set; }
		public string? Position { get; set; }
		public int? Department { get; set; }
		public string DepartmentName { get; set; }

		public virtual Department? DepartmentNavigation { get; set; }
	}
}
