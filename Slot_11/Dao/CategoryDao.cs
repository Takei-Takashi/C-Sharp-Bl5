using Slot_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_11.Dao
{
	public class CategoryDao
	{
		public List<Category> GetAllCategories()
		{
			List<Category> categories = new List<Category>();
			try
			{
				using(var context = new NorthwindContext())
				{
					return context.Categories.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
