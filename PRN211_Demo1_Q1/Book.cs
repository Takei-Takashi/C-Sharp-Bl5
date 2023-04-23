using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Demo1_Q1
{
    public class Book
    {
        private string code;
        private string title;
        private DateTime year;
        private List<string> author = new List<string>();

        public string Code { get => code; set => code = value; }
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("Title cannot be blank!");
                }
                else
                {
                    title = value;
                }
            }
        }
        public DateTime Year { get => year; set => year = value; }
        public List<string> Author { get => author; set => author = value; }
        public Book()
        {
            //author = new List<string>();
        }
        public Book(string code, string title, DateTime year)
        {
            this.code = code;
            this.title = title;
            this.year = year;
        }
        public Book(string code, string title, DateTime year, List<String> author)
        {
            this.code = code;
            this.title = title;
            this.year = year;
            this.author = author;
        }
        public void AddAuthor(string AuthorName)
        {
            if (author.Contains(AuthorName))
            {
                throw new ArgumentException("Author already exists!");
            }
            author.Add(AuthorName);
        }

        public override string ToString()
        {
            return "Book's Info: " + code + " - " + title + " - " + year.Year + "\nAuthors of book:\n" + string.Join("\n", author);
        }
    }
}
