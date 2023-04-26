﻿namespace PRN211_Demo1_Q3.Models
{
    public class Author_Book
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
