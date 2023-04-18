using Slot_12.Dao;
using Slot_12.Models;

namespace Slot_12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			checkBox1.Checked = true;
			checkBox2.Checked = true;
			dateTimePicker1.Enabled = false;
			dateTimePicker2.Enabled = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EmployeeDao employeeDao = new EmployeeDao();
			List<Employee> employees = employeeDao.GetAllEmployees();
			employees.Add(new Employee(0, "Choose", "Anyone"));
			comboBox1.DataSource = employees.OrderBy(e => e.EmployeeId).ToList();
			comboBox1.DisplayMember = "FullName";
			comboBox1.ValueMember = "EmployeeId";
			//dataGridView1.AutoGenerateColumns = false;
			//dataGridView1.Columns.Add("oid", "Order ID");
			//dataGridView1.Columns["oid"].DataPropertyName = "OrderId";

			//dataGridView1.Columns.Add("cid", "Customer ID");
			//dataGridView1.Columns["cid"].DataPropertyName = "CustomerId";

			//dataGridView1.Columns.Add("orderDate", "Order Date");
			//dataGridView1.Columns["orderDate"].DataPropertyName = "OrderDate";

			//dataGridView1.Columns.Add("requiredDate", "Required Date");
			//dataGridView1.Columns["requiredDate"].DataPropertyName = "RequiredDate";

			//dataGridView1.Columns.Add("ShippedDate", "Shipped Date");
			//dataGridView1.Columns["shippedDate"].DataPropertyName = "ShippedDate";

			//dataGridView1.Columns.Add("freight", "Freight");
			//dataGridView1.Columns["freight"].DataPropertyName = "Freight";

			//dataGridView1.Columns.Add("shipAddress", "Ship Address");
			//dataGridView1.Columns["shipAddress"].DataPropertyName = "ShipAddress";
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				dateTimePicker1.Enabled = false;
			}
			else
			{
				dateTimePicker1.Enabled = true;
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				dateTimePicker2.Enabled = false;
			}
			else
			{
				dateTimePicker2.Enabled = true;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			OrderDao orderDao = new OrderDao();
			Employee selectedEmployee = (Employee)comboBox1.SelectedItem;
			int employee = selectedEmployee.EmployeeId;
			DateTime? fr = null;
			DateTime? to = null;
			if(dateTimePicker1.Enabled == true)
			{
				fr = dateTimePicker1.Value;
			}
			if(dateTimePicker2.Enabled == true)
			{
				to = dateTimePicker2.Value;
			}
			List<Order> orders = orderDao.GetOrders(employee, fr, to);
			dataGridView1.DataSource = orders;
		}
	}
}