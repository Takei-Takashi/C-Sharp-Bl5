using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_8.Models
{
	public class Product
	{
		public string Name { get; set; }
		public string Category { get; set; }
		public int Price { get; set; }
		public bool IsActive { get; set; }
		public Product() { }
		public Product(string name, string category, int price, bool isActive)
		{
			this.Name = name;
			this.Category = category;
			this.Price = price;
			this.IsActive = isActive;
		}
		public override string ToString()
		{
			return $"Name = {Name}; Category = {Category}; Price = {Price}; Active = {IsActive}";
		}
	}
}
