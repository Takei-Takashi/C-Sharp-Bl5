using System;
using System.Collections.Generic;

namespace Gaming_Center.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Products = new HashSet<Product>();
        }

        public int GenresId { get; set; }
        public string GenresName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
