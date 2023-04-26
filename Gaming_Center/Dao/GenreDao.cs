using Gaming_Center.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming_Center.Dao
{
    public class GenreDao
    {
        public List<Genre> GetAllGenre()
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    return context.Genres.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Genre> GetAllGenresByProductId(int id)
        {
            try
            {
                using (var context = new Gaming_CenterContext())
                {
                    return context.Genres.Where(g => g.Products.Any(p => p.ProductId == id)).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
