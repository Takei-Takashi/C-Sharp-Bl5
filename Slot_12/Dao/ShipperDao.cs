using Slot_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_12.Dao
{
	public class ShipperDao
	{
		public List<Shipper> GetShippers()
		{
			try
			{
				using (var context = new NorthwindContext())
				{
					return context.Shippers.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public Shipper GetShipperByName(string name)
		{
			try
			{
				using (var context = new NorthwindContext())
				{
					var shipper = context.Shippers.FirstOrDefault(s => s.CompanyName == name);
					return shipper;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
