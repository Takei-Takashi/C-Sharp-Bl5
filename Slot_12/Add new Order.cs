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
			try
			{
                string employeeName = comboBox1.Text;
                string customerName = comboBox2.Text;
                string shipperName = comboBox3.Text;
                if (employeeName == "Choose Anyone" || customerName == "Choose another" || shipperName == "Choose another")
                {
                    throw new Exception();
                }
                DateTime requiredDate = dateTimePicker1.Value;
                List<Product> selectedProducts = new List<Product>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Product product = row.DataBoundItem as Product;
                    if (product != null)
                    {
                        selectedProducts.Add(product);
                    }
                }
                EmployeeDao employeeDao = new EmployeeDao();
                CustomerDao customerDao = new CustomerDao();
                ShipperDao shipperDao = new ShipperDao();
                Employee employee = employeeDao.GetEmployeeByName(employeeName);
                Customer customer = customerDao.GetCustomerByName(customerName);
                Shipper shipper = shipperDao.GetShipperByName(shipperName);

                Order order = new Order();
                order.CustomerId = customer.CustomerId;
                order.EmployeeId = employee.EmployeeId;
                order.OrderDate = DateTime.Now;
                order.RequiredDate = requiredDate;
                order.ShipVia = shipper.ShipperId;
                order.OrderDetails = new HashSet<OrderDetail>();

                OrderDao orderDao = new OrderDao();
                orderDao.AddOrder(order);
                foreach (Product product in selectedProducts)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.ProductId = product.ProductId;
                    orderDetail.Quantity = 1; // Số lượng sản phẩm mặc định là 1
                    orderDetail.UnitPrice = product.UnitPrice ?? 0;
                    orderDetail.Discount = 0; // Giảm giá mặc định là 0
                    order.OrderDetails.Add(orderDetail);
                }

                
                MessageBox.Show("Add order successfully!");

                this.Close();
                Form1 form1 = new Form1();
                form1.ReloadData();
            }
			catch (Exception ex)
			{
                MessageBox.Show($"Error: {ex.Message}");
            }
			
		}
	}
}
