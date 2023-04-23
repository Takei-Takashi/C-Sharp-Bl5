using PRN211_Demo1_Q2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Demo1_Q2.Dao
{
    public class BookDao
    {
        public List<Book> GetAllBooks()
        {
            try
            {
                using (var context = new PRN211_Demo1Context())
                {
                    return context.Books.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
