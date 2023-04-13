using System.Windows.Forms;
namespace Slot_6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = 0, y = 0;
			int distance = 40;
			try
			{
				int num = int.Parse(textBox1.Text);
				tableLayoutPanel1.Controls.Clear();

				tableLayoutPanel1.RowCount = 1;
				tableLayoutPanel1.ColumnCount = 2;
				List<CheckBox> checkBoxes = new List<CheckBox>();
				for (int i = 1; i <= num; i++)
				{
					CheckBox cb = new CheckBox();
					cb.Text = "Checkbox " + i;
					cb.Size = new Size(150, 50);
					cb.BackColor = Color.Transparent;
					cb.ForeColor = Color.White;
					cb.Font = new Font(cb.Font, FontStyle.Bold);
					checkBoxes.Add(cb);
				
					x++;
					y += distance; // tăng tọa độ y để các CheckBox không bị chồng chéo lên nhau
					tableLayoutPanel1.SetRow(cb, 0);
					if (i % 2 == 0) // Nếu Checkbox nằm ở vị trí chẵn, đặt nó vào cột thứ hai
					{
						tableLayoutPanel1.SetColumn(cb, 1);
						//tableLayoutPanel1.RowStyles[i] = new RowStyle(SizeType.Absolute, 30);
					}
					else // Nếu Checkbox nằm ở vị trí lẻ, đặt nó vào cột đầu tiên
					{
						tableLayoutPanel1.SetColumn(cb, 0);
						tableLayoutPanel1.RowStyles[i] = new RowStyle(SizeType.Absolute, 30);
					}
					/*cb.Location = new Point(x, y);*/ // cài đặt tọa độ cho CheckBox
					tableLayoutPanel1.Controls.Add(cb);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Input must be number. Please try again.", "Error", MessageBoxButtons.OK);
			}

		}
	}
}