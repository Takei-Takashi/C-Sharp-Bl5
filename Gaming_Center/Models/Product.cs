using System;
using System.Collections.Generic;

namespace Gaming_Center.Models
{
    public partial class Product
    {
        public Product()
        {
            Genres = new HashSet<Genre>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int PublisherId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }

        public virtual Publisher Publisher { get; set; } = null!;

        public virtual ICollection<Genre> Genres { get; set; }

        public Product(string name, int price, int discount, int publisherId, DateTime releasedate, List<Genre> genres)
        {
            this.ProductName = name;
            this.PublisherId = publisherId;
            this.ReleaseDate = releasedate;
            this.Price = price;
            this.Discount = discount;
            this.Genres = genres.ToHashSet();
        }
    }
}
