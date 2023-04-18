using Slot_11.Dao;
using Slot_11.Models;

namespace Slot_11
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CategoryDao categoryDao = new CategoryDao();
			// Lấy danh sách các Category từ CSDL
			List<Category> categories = categoryDao.GetAllCategories();
			categories.Add(new Category(0, "All categories", null, null));

			// Gán danh sách các Category vào DataSource của ComboBox
			comboBox1.DataSource = categories.OrderBy(c => c.CategoryId).ToList();
			

			// Thiết lập giá trị hiển thị cho các mục trong ComboBox
			comboBox1.DisplayMember = "CategoryName";

			// Thiết lập giá trị được chọn từ ComboBox
			comboBox1.ValueMember = "CategoryId";

			// Đăng ký sự kiện SelectionChanged cho comboBox1
			comboBox1.SelectedValueChanged += new EventHandler(comboBox1_SelectedIndexChanged);

			ProductDao productDao = new ProductDao();
			List<Product> products = productDao.GetProduct(null); // Lấy toàn bộ danh sách sản phẩm
			dataGridView1.DataSource = products;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Category selectedCategory = (Category)comboBox1.SelectedItem;
			int categoryId = selectedCategory.CategoryId;
			ProductDao productDao = new ProductDao();
			List<Product> products = productDao.GetProduct(categoryId); // Lấy danh sách sản phẩm tương ứng với Category được chọn

			dataGridView1.DataSource = products; // Gán danh sách sản phẩm vào DataSource của dataGridView1
		}
	}
}