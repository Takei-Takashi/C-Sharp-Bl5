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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ProductDao productDao = new ProductDao();
            List<Product> products = productDao.GetAllProduct();

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("pid", "ID");
            dataGridView1.Columns["pid"].DataPropertyName = "ProductId";
            dataGridView1.Columns["pid"].ReadOnly = true;
            dataGridView1.Columns["pid"].Width = 40;

            dataGridView1.Columns.Add("pname", "Product Name");
            dataGridView1.Columns["pname"].DataPropertyName = "ProductName";
            dataGridView1.Columns["pname"].ReadOnly = true;
            dataGridView1.Columns["pname"].Width = 250;

            dataGridView1.Columns.Add("pubName", "Publisher Name");
            dataGridView1.Columns["pubName"].DataPropertyName = "Publisher.PublisherName";
            dataGridView1.Columns["pubName"].ReadOnly = true;
            dataGridView1.Columns["pubName"].Width = 150;

            dataGridView1.Columns.Add("gName", "Genres");
            dataGridView1.Columns["gName"].DataPropertyName = "Genre";
            dataGridView1.Columns["gName"].ReadOnly = true;
            dataGridView1.Columns["gName"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["gName"].Width = 250;

            dataGridView1.Columns.Add("rd", "Release Date");
            dataGridView1.Columns["rd"].DataPropertyName = "ReleaseDate";
            dataGridView1.Columns["rd"].ReadOnly = true;
            dataGridView1.Columns["rd"].Width = 125;

            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns["price"].DataPropertyName = "Price";
            dataGridView1.Columns["price"].ReadOnly = true;
            dataGridView1.Columns["price"].Width = 100;

            dataGridView1.Columns.Add("discount", "Discount");
            dataGridView1.Columns["discount"].DataPropertyName = "Discount";
            dataGridView1.Columns["discount"].ReadOnly = true;
            dataGridView1.Columns["discount"].Width = 100;



            dataGridView1.DataSource = products;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "pubName")
            {
                Product product = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;
                if (product != null && product.Publisher != null) // Kiểm tra nếu product hoặc publisher không null mới thực hiện kết hợp tên nhà sản xuất
                {
                    string publisherName = product.Publisher.PublisherName;
                    e.Value = publisherName;
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "gName")
            {
                Product product = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;
                if (product != null) // Kiểm tra nếu product không null mới thực hiện kết hợp tên thể loại
                {
                    string genres = string.Join(", ", product.Genres.Select(g => g.GenresName));
                    e.Value = genres;
                    e.FormattingApplied = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim();
            ProductDao productDao = new ProductDao();
            List<Product> products = productDao.GetProductsByString(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow != null)
            {
                // Get the ProductId from the selected row
                int productId = Convert.ToInt32(selectedRow.Cells["pid"].Value);

                // Instantiate the ProductDao class
                ProductDao productDao = new ProductDao();

                // Call the DeleteProduct method to delete the selected product
                productDao.DeleteProduct(productId);

                // Reload the data grid view to reflect the changes
                Form2_Load(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow != null)
            {
                // Get the ProductId from the selected row
                int productId = Convert.ToInt32(selectedRow.Cells["pid"].Value);

                // Instantiate the ProductDao class
                ProductDao productDao = new ProductDao();

                // Get the selected product
                Product selectedProduct = productDao.GetProductById(productId);

                // Pass the selected product to the EditForm
                this.Hide();
                EditForm editForm = new EditForm();
                editForm.SelectedProduct = selectedProduct;
                editForm.FormClosed += (s, args) =>
                {
                    Form2_Load(sender, e);
                    this.Show();
                };
                editForm.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();
            addForm.FormClosed += (s, args) =>
            {
                Form2_Load(sender, e);
                this.Show();
            };
            addForm.ShowDialog();
        }
    }
}
