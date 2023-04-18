using Slot_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_12.Dao
{
	public class OrderDao
	{
		public List<Order> GetOrders(int emp, DateTime? fr, DateTime? to)
		{
			List<Order> orders = new List<Order>();
			try
			{
				using (var context = new NorthwindContext())
				{
					if (!fr.HasValue && !to.HasValue)
					{
						orders = context.Orders.Where(o => o.EmployeeId == emp).ToList();
					}
					else if (!fr.HasValue && to.HasValue)
					{
						orders = context.Orders.Where(o => o.EmployeeId == emp && o.OrderDate <= to.Value).ToList();
					}
					else if (fr.HasValue && !to.HasValue)
					{
						orders = context.Orders.Where(o => o.EmployeeId == emp && o.OrderDate >= fr.Value).ToList();
					}
					else if (fr.HasValue && to.HasValue)
					{
						orders = context.Orders.Where(o => o.EmployeeId == emp && o.OrderDate >= fr.Value && o.OrderDate <= to.Value).ToList();
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
			return orders;
		}
	}
}
