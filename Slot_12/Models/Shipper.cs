using System;
using System.Collections.Generic;

namespace Slot_12.Models
{
	public partial class Shipper
	{
		public Shipper()
		{
			Orders = new HashSet<Order>();
		}

		public Shipper(int v1, string v2)
		{
			this.ShipperId = v1;
			this.CompanyName = v2;
		}

		public int ShipperId { get; set; }
		public string CompanyName { get; set; } = null!;
		public string? Phone { get; set; }

		public virtual ICollection<Order> Orders { get; set; }
	}
}
