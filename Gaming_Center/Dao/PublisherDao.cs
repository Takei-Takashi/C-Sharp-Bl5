using Gaming_Center.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Center.Dao
{
    public class PublisherDao
    {
        public List<Publisher> GetAllPublisher()
        {
			try
			{
				using (var context = new Gaming_CenterContext())
				{
					return context.Publishers.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
