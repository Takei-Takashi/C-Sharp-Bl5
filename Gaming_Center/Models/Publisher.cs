﻿using System;
using System.Collections.Generic;

namespace Gaming_Center.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Products = new HashSet<Product>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
