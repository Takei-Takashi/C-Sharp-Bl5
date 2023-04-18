using System;
using System.Collections.Generic;

namespace Slot_11.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

		public Category(int v1, string v2, string value1, byte[] value2)
		{
            this.CategoryId = v1;
            this.CategoryName = v2;
            this.Description = value1;
            this.Picture = value2;
		}

		public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
