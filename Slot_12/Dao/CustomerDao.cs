using Slot_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_12.Dao
{
	public class CustomerDao
	{
		public List<Customer> GetCustomers()
		{
			try
			{
				using (var context = new NorthwindContext())
				{
					return context.Customers.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public Customer GetCustomerByName(string name)
		{
			try
			{
				using (var context = new NorthwindContext())
				{
					var customer = context.Customers.FirstOrDefault(c => c.CompanyName == name);
					return customer;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
