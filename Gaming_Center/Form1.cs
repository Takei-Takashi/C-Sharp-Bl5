using Gaming_Center.Dao;
using Gaming_Center.Models;

namespace Gaming_Center
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountDao accountDao = new AccountDao();
            Account account = accountDao.GetAccount(textBox1.Text.Trim(), textBox2.Text.Trim());
            if (account == null)
            {
                MessageBox.Show("Wrong username or password.", "Login fail", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Show();
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

    }
}