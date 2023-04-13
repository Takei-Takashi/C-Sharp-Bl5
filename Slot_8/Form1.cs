using Slot_8.Models;

namespace Slot_8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//int x = 0, y = 0;
			try
			{
				int input = int.Parse(textBox1.Text);
				tableLayoutPanel1.Controls.Clear();
				tableLayoutPanel1.ColumnCount = 4;
				tableLayoutPanel1.RowCount = input;
				tableLayoutPanel1.ColumnStyles.Clear();
				tableLayoutPanel1.RowStyles.Clear();
				for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
				{
					tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
				}
				for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
				{
					tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
					var textBox1 = new TextBox()
					{
						Dock = DockStyle.Fill,
						Anchor = AnchorStyles.Left | AnchorStyles.Right,
						Margin = new Padding(5),
						Padding = new Padding(5),
					};
					var textBox2 = new TextBox()
					{
						Dock = DockStyle.Fill,
						Anchor = AnchorStyles.Left | AnchorStyles.Right,
						Margin = new Padding(5),
						Padding = new Padding(5),
					};
					var textBox3 = new TextBox()
					{
						Dock = DockStyle.Fill,
						Anchor = AnchorStyles.Left | AnchorStyles.Right,
						Margin = new Padding(5),
						Padding = new Padding(5),
					};
					var checkBox = new CheckBox()
					{
						Dock = DockStyle.Fill,
						Text = "Active",
						Anchor = AnchorStyles.Left | AnchorStyles.Right,
						Margin = new Padding(0),
					};

					tableLayoutPanel1.Controls.Add(textBox1, 0, i);
					tableLayoutPanel1.Controls.Add(textBox2, 1, i);
					tableLayoutPanel1.Controls.Add(textBox3, 2, i);
					tableLayoutPanel1.Controls.Add(checkBox, 3, i);
				}
				tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 40;
			}
			catch (Exception)
			{
				MessageBox.Show("Input must be number. Please try again.", "Error", MessageBoxButtons.OK);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<Product> products = new List<Product>();
			try
			{
				for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
				{
					var txtBox1 = tableLayoutPanel1.GetControlFromPosition(0, i) as TextBox;
					var txtBox2 = tableLayoutPanel1.GetControlFromPosition(1, i) as TextBox;
					var txtBox3 = tableLayoutPanel1.GetControlFromPosition(2, i) as TextBox;
					var checkBox = tableLayoutPanel1.GetControlFromPosition(3, i) as CheckBox;
					int price;
					if (txtBox1.Text == "" || txtBox2.Text == "" || txtBox3.Text == "")
						throw new NullReferenceException();
					if (!int.TryParse(txtBox3.Text, out price))
						throw new FormatException();
					string name = txtBox1.Text;
					string cate = txtBox2.Text;
					bool isActive;
					if (checkBox.Checked)
					{
						isActive = true;
					}
					else isActive = false;
					Product product = new Product(name, cate, price, isActive);
					products.Add(product);
				}
				MessageBox.Show("Add successfully.", "Message", MessageBoxButtons.OK);
			}
			catch (NullReferenceException)
			{
				MessageBox.Show("Input can not null.", "Something was null", MessageBoxButtons.OK);
			}
			catch (FormatException)
			{
				MessageBox.Show("Price must be number.", "Something was wrong", MessageBoxButtons.OK);
			}
			File.WriteAllText(@"D:\Visual Studio Code\Bl5\Slot_8\Product.txt", string.Empty);
			StreamWriter sw = new StreamWriter(@"D:\Visual Studio Code\Bl5\Slot_8\Product.txt");

			foreach (Product pro in products)
			{
				sw.WriteLine(pro.ToString());
			}

			sw.Close();
		}
	}
}