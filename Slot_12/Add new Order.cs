using Slot_12.Dao;
using Slot_12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_12
{
	public partial class Add_new_Order : Form
	{
		public Add_new_Order()
		{
			InitializeComponent();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void Add_new_Order_Load(object sender, EventArgs e)
		{
			EmployeeDao employeeDao = new EmployeeDao();
			CustomerDao customerDao = new CustomerDao();
			ShipperDao shipperDao = new ShipperDao();
			ProductDao productDao = new ProductDao();

			List<Employee> employees = employeeDao.GetAllEmployees();
			employees.Add(new Employee(0, "Choose", "Anyone"));
			List<Customer> customers = customerDao.GetCustomers();
			customers.Add(new Customer("0", "Choose another"));
			List<Shipper> shippers = shipperDao.GetShippers();
			shippers.Add(new Shipper(0, "Choose another"));
			List<ProductWithCategory> products = productDao.GetProductsWithCategory();
			comboBox1.DataSource = employees.OrderBy(e => e.EmployeeId).ToList();
			comboBox1.DisplayMember = "FullName";
			comboBox1.ValueMember = "EmployeeId";
			comboBox2.DataSource = customers.OrderBy(c => c.CustomerId).ToList();
			comboBox2.DisplayMember = "CompanyName";
			comboBox2.ValueMember = "CustomerId";
			comboBox3.DataSource = shippers.OrderBy(s => s.ShipperId).ToList();
			comboBox3.DisplayMember = "CompanyName";
			comboBox3.ValueMember = "ShipperId";
			dataGridView1.DataSource = products;
			dataGridView1.Columns.Clear();
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.Columns.Add("ProductId", "ID");
			dataGridView1.Columns["ProductId"].DataPropertyName = "ProductId";

			dataGridView1.Columns.Add("ProductName", "Product Name");
			dataGridView1.Columns["ProductName"].DataPropertyName = "ProductName";

			dataGridView1.Columns.Add("CategoryName", "Category Name");
			dataGridView1.Columns["CategoryName"].DataPropertyName = "CategoryName";

			dataGridView1.Columns.Add("QuantityPerUnit", "Quantity");
			dataGridView1.Columns["QuantityPerUnit"].DataPropertyName = "QuantityPerUnit";

			dataGridView1.Columns.Add("UnitPrice", "Price");
			dataGridView1.Columns["UnitPrice"].DataPropertyName = "UnitPrice";

			dataGridView1.Columns.Add("UnitsInStock", "Stock");
			dataGridView1.Columns["UnitsInStock"].DataPropertyName = "UnitsInStock";

			dataGridView1.Columns.Add("UnitsOnOrder", "On Order");
			dataGridView1.Columns["UnitsOnOrder"].DataPropertyName = "UnitsOnOrder";

			dataGridView1.Columns["ProductId"].ReadOnly = true;
			dataGridView1.Columns["ProductName"].ReadOnly = true;
			dataGridView1.Columns["CategoryName"].ReadOnly = true;
			dataGridView1.Columns["QuantityPerUnit"].ReadOnly = true;
			dataGridView1.Columns["UnitPrice"].ReadOnly = true;
			dataGridView1.Columns["UnitsInStock"].ReadOnly = true;
			dataGridView1.Columns["UnitsOnOrder"].ReadOnly = true;

		}


		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			ProductDao productDao = new ProductDao();
			List<ProductWithCategory> products = productDao.GetProductsWithCategory().OrderByDescending(p => p.UnitPrice).ToList();
			dataGridView1.DataSource = products;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			ProductDao productDao = new ProductDao();
			List<ProductWithCategory> products = productDao.GetProductsWithCategory().OrderBy(p => p.UnitPrice).ToList();
			dataGridView1.DataSource = products;
		}


		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			ProductDao productDao = new ProductDao();
			List<ProductWithCategory> products = productDao.GetProductsWithCategory().OrderBy(p => p.ProductId).ToList();
			dataGridView1.DataSource = products;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
