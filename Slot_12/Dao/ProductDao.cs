using Slot_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_12.Dao
{
	public class ProductDao
	{
		public List<Product> GetProducts()
		{
			try
			{
				using (var context = new NorthwindContext())
				{
					return context.Products.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public List<ProductWithCategory> GetProductsWithCategory()
		{
			try
			{
				using (var context = new NorthwindContext())
				{
					var productsWithCategory = from p in context.Products
											   join c in context.Categories
											   on p.CategoryId equals c.CategoryId
											   select new ProductWithCategory
											   {
												   ProductId = p.ProductId,
												   ProductName = p.ProductName,
												   CategoryName = c.CategoryName,
												   QuantityPerUnit = p.QuantityPerUnit,
												   UnitPrice = p.UnitPrice,
												   UnitsInStock = p.UnitsInStock,
												   UnitsOnOrder = p.UnitsOnOrder
											   };
					return productsWithCategory.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

	}
}
