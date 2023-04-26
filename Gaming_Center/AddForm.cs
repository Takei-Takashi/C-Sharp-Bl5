using Gaming_Center.Dao;
using Gaming_Center.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_Center
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            GenreDao genreDao = new GenreDao();
            PublisherDao publisherDao = new PublisherDao();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DisplayMember = "PublisherName";
            comboBox1.DataSource = publisherDao.GetAllPublisher();
            List<Genre> genres = genreDao.GetAllGenre();

            // Set column styles
            for (int i = 0; i < 5; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            }

            int row = 0;
            int col = 0;

            foreach (var genre in genres)
            {
                CheckBox checkbox = new CheckBox();
                checkbox.Text = genre.GenresName;
                checkbox.Tag = genre;

                // Add the checkbox to the appropriate cell in the table layout panel
                tableLayoutPanel1.Controls.Add(checkbox, col, row);

                // Increment the column counter
                col++;

                // If we've reached the end of a row, move to the next row and reset the column counter
                if (col == 5)
                {
                    col = 0;
                    row++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text;
                int price = int.Parse(textBox3.Text);
                int discount = int.Parse(textBox4.Text);
                DateTime releaseDate = dateTimePicker1.Value;
                int publisherId = ((Publisher)comboBox1.SelectedItem).PublisherId;
                List<Genre> genres = new List<Genre>();

                Product product = new Product
                {
                    ProductName = name,
                    PublisherId = publisherId,
                    ReleaseDate = releaseDate,
                    Price = price,
                    Discount = discount
                };

                foreach (var control in tableLayoutPanel1.Controls)
                {
                    if (control is CheckBox && ((CheckBox)control).Checked)
                    {
                        Genre genre = (Genre)((CheckBox)control).Tag;
                        genres.Add(genre);
                    }
                }
                ProductDao productDao = new ProductDao();
                bool result = productDao.InsertProduct(product, genres);

                // Hiển thị thông báo cho người dùng
                if (result)
                {
                    MessageBox.Show("Product has been added successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error occurred while adding product.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred while adding product.");
                throw;
            }
        }
    }
}
