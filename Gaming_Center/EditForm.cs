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
    public partial class EditForm : Form
    {
        public Product SelectedProduct { get; set; }
        public EditForm()
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

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (SelectedProduct != null)
            {
                textBox1.Text = SelectedProduct.ProductId.ToString();
                textBox2.Text = SelectedProduct.ProductName;
                comboBox1.Text = SelectedProduct.Publisher.PublisherName;
                dateTimePicker1.Value = SelectedProduct.ReleaseDate;
                textBox3.Text = SelectedProduct.Price.ToString();
                textBox4.Text = SelectedProduct.Discount.ToString();
                GenreDao genreDao = new GenreDao();
                List<Genre> genres = genreDao.GetAllGenresByProductId(SelectedProduct.ProductId);

                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        Genre genre = genres.Find(g => g.GenresName == checkBox.Text);
                        if (genre != null)
                        {
                            checkBox.Checked = true;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin các trường đã chỉnh sửa của sản phẩm
                string productName = textBox2.Text;
                Publisher publisher = (Publisher)comboBox1.SelectedItem;
                DateTime releaseDate = dateTimePicker1.Value;
                int price = int.Parse(textBox3.Text);
                int discount = int.Parse(textBox4.Text);

                // Lấy danh sách genres mới được chọn
                List<Genre> selectedGenres = new List<Genre>();
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        Genre genre = new Genre
                        {
                            GenresName = checkBox.Text
                        };
                        selectedGenres.Add(genre);
                    }
                }

                // Tạo đối tượng Product mới để cập nhật vào database
                Product updatedProduct = new Product
                {
                    ProductId = SelectedProduct.ProductId,
                    ProductName = productName,
                    PublisherId = publisher.PublisherId,
                    ReleaseDate = releaseDate,
                    Price = price,
                    Discount = discount,
                    Genres = selectedGenres
                };

                // Cập nhật sản phẩm được chọn
                ProductDao productDao = new ProductDao();
                productDao.UpdateProduct(updatedProduct);

                MessageBox.Show("Edit success.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
