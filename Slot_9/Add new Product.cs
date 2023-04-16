using Slot_9.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_9
{
	public partial class Add_new_Product : Form
	{
		public List<Product> Products { get; set; }
		public bool IsAddedSuccessfully { get; set; }

		public Add_new_Product()
		{

			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox2 == null || textBox3 == null || textBox4 == null || textBox5 == null)
					throw new NullReferenceException();
				int id = int.Parse(textBox1.Text.Trim());
				string name = textBox2.Text.Trim();
				string category = textBox3.Text.Trim();
				double price = double.Parse(textBox4.Text.Trim());
				int amount = int.Parse(textBox5.Text.Trim());
				bool active = checkBox1.Checked;
				Product product = new Product(id, name, category, price, amount, active);
				Products.Add(product);
				MessageBox.Show("Addition successfully.", "Error", MessageBoxButtons.OK);
				IsAddedSuccessfully = true;
				this.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("We have some problem here. Please try again.", "Error", MessageBoxButtons.OK);
				throw;
			}
		}

		private void Add_new_Product_Load(object sender, EventArgs e)
		{
			if (Products != null && Products.Count > 0)
			{
				// Tìm kiếm sản phẩm có Id lớn nhất trong danh sách
				int maxId = Products.Max(p => p.Id);

				// Hiển thị kết quả tìm kiếm
				textBox1.Text = maxId + 1 + "";
				;
			}
			else
			{
				// Nếu danh sách sản phẩm null hoặc không có phần tử nào
				textBox1.Text = "1";
			}
		}
	}
}
