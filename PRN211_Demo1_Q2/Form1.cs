using Microsoft.EntityFrameworkCore;
using PRN211_Demo1_Q2.Dao;
using PRN211_Demo1_Q2.Models;

namespace PRN211_Demo1_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            BookDao bookDao = new BookDao();
            List<Book> books = bookDao.GetAllBooks();
            comboBox1.DisplayMember = "Title";
            comboBox1.DataSource = books;
            comboBox1.SelectedIndex = 0;

            // Subscribe to the SelectedIndexChanged event of comboBox1
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            for (int i = 2000; i <= 2010; i++)
            {
                comboBox2.Items.Add(i);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected book from comboBox1
            Book selectedBook = comboBox1.SelectedItem as Book;

            if (selectedBook != null)
            {
                // Set the text of comboBox2 to the year of the selected book
                comboBox2.Text = selectedBook.Year.ToString();

                // Clear the items in the listBox1
                listBox1.Items.Clear();
                listBox1.DisplayMember = "Name";

                // Load the list of authors into listBox1
                using (var context = new PRN211_Demo1Context())
                {
                    selectedBook = context.Books
                        .Include(b => b.Authors)
                        .SingleOrDefault(b => b.Id == selectedBook.Id);

                    if (selectedBook != null)
                    {
                        foreach (Author author in selectedBook.Authors)
                        {
                            listBox1.Items.Add(author.Name);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected book from comboBox1
            Book selectedBook = comboBox1.SelectedItem as Book;

            if (selectedBook != null)
            {
                // Get the selected author from listBox1
                string selectedAuthor = listBox1.SelectedItem as string;

                if (selectedAuthor != null)
                {
                    // Show a confirmation dialog
                    DialogResult result = MessageBox.Show("Do you really want to remove this author ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Find the author in the list of authors for the book
                        Author authorToRemove = selectedBook.Authors.SingleOrDefault(a => a.Name == selectedAuthor);

                        if (authorToRemove != null)
                        {
                            // Remove the author from the list of authors for the book
                            selectedBook.Authors.Remove(authorToRemove);

                            using (var dbContext = new PRN211_Demo1Context())
                            {
                                // Save the changes to the database
                                dbContext.Update(selectedBook);
                                dbContext.SaveChanges();
                            }

                            // Refresh the list of authors in listBox1
                            listBox1.Items.Clear();
                            foreach (Author author in selectedBook.Authors)
                            {
                                listBox1.Items.Add(author.Name);
                            }
                        }
                    }
                }
            }
        }
    }
}