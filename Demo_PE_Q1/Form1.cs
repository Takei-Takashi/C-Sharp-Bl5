using Demo_PE_Q1.Dao;
using Demo_PE_Q1.Models;

namespace Demo_PE_Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.SelectedIndex = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EmployeeDao employeeDao = new EmployeeDao();
			//List<Employee> employees = employeeDao.GetAllEmployeeWithDepartment();

			using (var context = new PE_Fall21B5Context())
			{
				var listEmployees = context.Employees.Join(context.Departments,
					e => e.Department,
					d => d.Id,
					(e, d) => new EmployeeWithDepartment
					{
						Id = e.Id,
						Name = e.Name,
						Dob = e.Dob,
						Sex = e.Sex,
						Position = e.Position,
						Department = e.Department,
						DepartmentName = d.Name
					}).ToList();
				dataGridView1.DataSource = listEmployees;
			}

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

			dataGridView1.Columns.Add("department", "Department");
			dataGridView1.Columns["department"].DataPropertyName = "Department";
			dataGridView1.Columns["department"].ReadOnly = true;

			dataGridView1.Columns.Add("departmentName", "Department Name");
			dataGridView1.Columns["departmentName"].DataPropertyName = "DepartmentName";
			dataGridView1.Columns["departmentName"].ReadOnly = true;

			//dataGridView1.DataSource = employees;
		}

		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			LoadDataGridView();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			LoadDataGridView();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			LoadDataGridView();
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			LoadDataGridView();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			LoadDataGridView();
		}
		private void LoadDataGridView()
		{
			EmployeeDao employeeDao = new EmployeeDao();
			List<EmployeeWithDepartment> employees = employeeDao.GetEmployeeWithDepartments();

			// Thực hiện tìm kiếm và lọc dữ liệu theo giá trị của các điều khiển trong GroupBox Filter
			if (comboBox1.SelectedIndex != 0)
			{
				employees = employees.Where(e => e.Position == comboBox1.SelectedItem.ToString()).ToList();
			}

			if (radioButton1.Checked)
			{
				// Không áp dụng bộ lọc theo giới tính nếu RadioButton "Male/Female" được chọn
			}
			else if (radioButton2.Checked)
			{
				employees = employees.Where(e => e.Sex == "Male").ToList();
			}
			else if (radioButton3.Checked)
			{
				employees = employees.Where(e => e.Sex == "Female").ToList();
			}

			if (!string.IsNullOrEmpty(textBox1.Text))
			{
				employees = employees.Where(e => e.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
			}

			// Cập nhật dữ liệu trên DataGridView
			dataGridView1.DataSource = employees;
		}
	}
}