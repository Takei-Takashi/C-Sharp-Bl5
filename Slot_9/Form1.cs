using Slot_9.Models;
using System.Windows.Forms;

namespace Slot_9
{
	public partial class Form1 : Form
	{
		string filePath;
		public List<Product> products = new List<Product>();
		public Form1()
		{

			InitializeComponent();
		}



		private void button1_Click_1(object sender, EventArgs e)
		{
			if (Browse.ShowDialog() == DialogResult.OK)
			{
				// xử lý tập tin đã chọn ở đây
			}
		}

		private void Browse_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Lấy ra đường dẫn của file đã chọn
			filePath = Browse.FileName;

			// Hiển thị đường dẫn lên TextBox
			textBox1.Text = filePath;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			products = new List<Product>();
			string FilePath = filePath;
			
			try
			{
				if (dataGridView1.DataSource != null)
				{
					// Clear danh sách sản phẩm và dữ liệu trên DataGridView
					products.Clear();
					dataGridView1.DataSource = null;
					dataGridView1.Columns.Clear();
				}
				if (filePath == null)
					throw new NullReferenceException();
				string[] lines = File.ReadAllLines(FilePath);
				foreach (string line in lines)
				{
					try
					{
						string[] fields = line.Split(';');
						int id = int.Parse(fields[0].Trim());
						string name = fields[1].Trim();
						string cate = fields[2].Trim();
						double price = double.Parse(fields[3].Trim());
						int amount = int.Parse(fields[4].Trim());
						bool active = bool.Parse(fields[5].Trim());
						Product product = new Product(id, name, cate, price, amount, active);
						products.Add(product);
					}
					catch (Exception)
					{
						continue;
					}
				}
				dataGridView1.AutoGenerateColumns = false;
				// Gán danh sách sản phẩm vào DataSource của dataGridView1
				dataGridView1.DataSource = products;

				// Khai báo các cột dữ liệu cho dataGridView1
				DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
				idColumn.DataPropertyName = "Id";
				idColumn.HeaderText = "ID";
				idColumn.Name = "idColumn";

				DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
				nameColumn.DataPropertyName = "Name";
				nameColumn.HeaderText = "Name";
				nameColumn.Name = "nameColumn";

				DataGridViewTextBoxColumn cateColumn = new DataGridViewTextBoxColumn();
				cateColumn.DataPropertyName = "Category";
				cateColumn.HeaderText = "Category";
				cateColumn.Name = "cateColumn";

				DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
				priceColumn.DataPropertyName = "Price";
				priceColumn.HeaderText = "Price";
				priceColumn.Name = "priceColumn";

				DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
				amountColumn.DataPropertyName = "Amount";
				amountColumn.HeaderText = "Amount";
				amountColumn.Name = "amountColumn";

				DataGridViewCheckBoxColumn activeColumn = new DataGridViewCheckBoxColumn();
				activeColumn.DataPropertyName = "Active";
				activeColumn.HeaderText = "Active";
				activeColumn.Name = "activeColumn";

				// Thêm các cột dữ liệu vào dataGridView1
				dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idColumn, nameColumn, cateColumn, priceColumn, amountColumn, activeColumn });
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Haven't selected a file to read.", "Error", MessageBoxButtons.OK);
			}
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Add_new_Product add_New_Product = new Add_new_Product();
			add_New_Product.Products = products;
			add_New_Product.ShowDialog();
			if (add_New_Product.IsAddedSuccessfully)
			{
				dataGridView1.DataSource = null;
				dataGridView1.DataSource = products;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (Save.ShowDialog() == DialogResult.OK)
			{
				string fileName = Save.FileName;
				using (StreamWriter writer = new StreamWriter(fileName))
				{
					foreach (Product p in products)
					{
						writer.WriteLine("{0};{1};{2};{3};{4};{5}", p.Id, p.Name, p.Category, p.Price, p.Amount, p.Active);
					}
				}
			}
		}
	}
}