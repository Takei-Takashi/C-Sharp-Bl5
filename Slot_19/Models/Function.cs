namespace Slot_19.Models
{
	public class Function
	{
		public List<Product> GetProducts(int cid, int dis, List<Product> products)
		{
			List<Product> list = new List<Product>();
			if (dis == 0)
			{
				foreach (var product in products)
				{
					if (product.CategoryId == cid)
					{
						list.Add(product);
					}
				}
			}
			else if (dis == 1)
			{
				foreach (var product in products)
				{
					if (product.CategoryId == cid)
					{
						list.Add(product);
					}
				}
			} else
			{
				foreach (var product in products)
				{
					if (product.CategoryId == cid)
					{
						list.Add(product);
					}
				}
			}
			return list;
		}
	}
}
