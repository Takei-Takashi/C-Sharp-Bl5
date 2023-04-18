using Slot_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_11.Dao
{
	public class ProductDao
	{
		public List<Product> GetProduct(int? category)
		{
			List<Product> products = new List<Product>();
			try
			{
				using(var context = new NorthwindContext())
				{
					if(!category.HasValue || category == 0)
					{
						products = context.Products.ToList();
					} else
					{
						products = context.Products.Where(p => p.CategoryId == category).ToList();
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
			return products;
		}
	}
}
