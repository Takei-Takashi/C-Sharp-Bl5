using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_9.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name
		{
			get; set;
		}
		public string Category
		{
			get; set;
		}
		public double Price
		{
			get; set;
		}
		public int Amount
		{
			get; set;
		}
		public bool Active
		{
			get; set;
		}
		public Product() { }
		public Product(int id, string name, string category, double price, int amount, bool active)
		{
			this.Id = id;
			this.Name = name;
			this.Category = category;
			this.Price = price;
			this.Amount = amount;
			this.Active = active;
		}

		public override string ToString()
		{
			return $"Id = {Id}; Name = {Name}; Category = {Category}; Price = {Price}; Amount = {Amount}; Active = {Active}";
		}
	}
}
