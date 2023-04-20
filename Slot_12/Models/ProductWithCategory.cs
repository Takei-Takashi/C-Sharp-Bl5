using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_12.Models
{
	public class ProductWithCategory
	{
		public ProductWithCategory()
		{
			OrderDetails = new HashSet<OrderDetail>();
		}

		public int ProductId { get; set; }
		public string ProductName { get; set; } = null!;
		public int? SupplierId { get; set; }
		public int? CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string? QuantityPerUnit { get; set; }
		public decimal? UnitPrice { get; set; }
		public short? UnitsInStock { get; set; }
		public short? UnitsOnOrder { get; set; }
		public short? ReorderLevel { get; set; }
		public bool Discontinued { get; set; }

		public virtual Category? Category { get; set; }
		public virtual Supplier? Supplier { get; set; }
		public virtual ICollection<OrderDetail> OrderDetails { get; set; }
	}
}
