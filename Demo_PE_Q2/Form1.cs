using Demo_PE_Q2.Dao;
using Demo_PE_Q2.Models;

namespace Demo_PE_Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			using (var context = new PE_Fall21B5Context())
			{
				var positionList = context.Employees.Select(e => e.Position).Distinct().ToList();
				comboBox1.DataSource = positionList;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EmployeeDao employeeDao = new EmployeeDao();
			dataGridView1.DataSource = employeeDao.GetAllEmplpoyee();
			dataGridView1.Columns.Clear();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.Columns.Add("id", "ID");
			dataGridView1.Columns["id"].DataPropertyName = "Id";
			dataGridView1.Columns["id"].ReadOnly = true;

			dataGridView1.Columns.Add("name", "Name");
			dataGridView1.Columns["name"].DataPropertyName = "Name";
			dataGridView1.Columns["name"].ReadOnly = true;

			dataGridView1.Columns.Add("dob", "DOB");
			dataGridView1.Columns["dob"].DataPropertyName = "Dob";
			dataGridView1.Columns["dob"].ReadOnly = true;

			dataGridView1.Columns.Add("sex", "Sex");
			dataGridView1.Columns["sex"].DataPropertyName = "Sex";
			dataGridView1.Columns["sex"].ReadOnly = true;

			dataGridView1.Columns.Add("position", "Position");
			dataGridView1.Columns["position"].DataPropertyName = "Position";
			dataGridView1.Columns["position"].ReadOnly = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				using (var context = new PE_Fall21B5Context())
				{
					// Retrieve values from controls
					string name = textBox2.Text.Trim();
					DateTime dob = dateTimePicker1.Value;
					string sex = radioButton1.Checked ? "Male" : "Female";
					string position = comboBox1.SelectedItem?.ToString();

					// Create new Employee object
					Employee newEmployee = new Employee
					{
						Name = name,
						Dob = dob,
						Sex = sex,
						Position = position
					};

					// Add new Employee to database
					context.Employees.Add(newEmployee);
					context.SaveChanges();

					// Reload data in DataGridView
					Form1_Load(sender, e);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0)
				{
					int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

					using (var context = new PE_Fall21B5Context())
					{
						var employee = context.Employees.Find(id);

						if (employee != null)
						{
							textBox1.Text = employee.Id.ToString();
							textBox2.Text = employee.Name;
							dateTimePicker1.Value = employee.Dob;

							if (employee.Sex == "Male")
								radioButton1.Checked = true;
							else if (employee.Sex == "Female")
								radioButton2.Checked = true;
							else
							{
								radioButton1.Checked = false;
								radioButton2.Checked = false;
							}

							comboBox1.SelectedItem = employee.Position;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				int id = int.Parse(textBox1.Text);

				using (var context = new PE_Fall21B5Context())
				{
					var employee = context.Employees.Find(id);

					if (employee != null)
					{
						employee.Name = textBox2.Text.Trim();
						employee.Dob = dateTimePicker1.Value;
						employee.Sex = radioButton1.Checked ? "Male" : "Female";
						employee.Position = comboBox1.SelectedItem?.ToString();

						context.SaveChanges();

						Form1_Load(sender, e);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			dateTimePicker1.Value = DateTime.Now;
			comboBox1.SelectedItem = comboBox1.Items[0];
		}
	}
}