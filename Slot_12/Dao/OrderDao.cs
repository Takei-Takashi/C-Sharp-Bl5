using Microsoft.EntityFrameworkCore;
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
		private static int orderId = 0;
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
		private int GetLastOrderId()
		{
			using (var context = new NorthwindContext())
			{
				var order = context.Orders.OrderByDescending(o => o.OrderId).FirstOrDefault();
				if (order != null)
				{
					return order.OrderId;
				}
				else
				{
					return 0;
				}
			}
		}
		public void AddOrder(Order order)
		{
			using (var context = new NorthwindContext())
			{
				// Lấy giá trị của OrderId cuối cùng đã được thêm vào CSDL
				//int lastOrderId = GetLastOrderId();

				// Tăng giá trị của orderId lên 1
				//orderId++;

				// Gán giá trị của OrderId cho đối tượng Order mới
				//order.OrderId = lastOrderId + 1;

				context.Orders.Add(order);
				// Bật chế độ IDENTITY_INSERT cho bảng Orders
				//context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Orders ON");

				context.SaveChanges();


			}
			//using (var context = new NorthwindContext())
			//{
			//	// Tắt chế độ IDENTITY_INSERT cho bảng Orders
			//	context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Orders OFF");
			//}
		}

	}
}
