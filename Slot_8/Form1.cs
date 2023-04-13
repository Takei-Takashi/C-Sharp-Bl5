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
			int x = 0, y = 0, distance = 40;
			try
			{
				int input = int.Parse(textBox1.Text);
				tableLayoutPanel1.Controls.Clear();
				tableLayoutPanel1.ColumnCount = 4;
				tableLayoutPanel1.RowCount = input;
				for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
				{
					tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
					var textBox1 = new TextBox()
					{
						Dock = DockStyle.Fill,
					};
					var textBox2 = new TextBox()
					{
						Dock = DockStyle.Fill,
					};
					var textBox3 = new TextBox()
					{
						Dock = DockStyle.Fill,
					};
					var checkBox = new CheckBox()
					{
						Dock = DockStyle.Fill,
						Text = "Active",
					};

					tableLayoutPanel1.Controls.Add(textBox1, 0, i);
					tableLayoutPanel1.Controls.Add(textBox2, 1, i);
					tableLayoutPanel1.Controls.Add(textBox3, 2, i);
					tableLayoutPanel1.Controls.Add(checkBox, 3, i);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Input must be number. Please try again.", "Error", MessageBoxButtons.OK);
			}
		}
	}
}