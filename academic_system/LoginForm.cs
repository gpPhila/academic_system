using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academic_system
{
    public partial class LoginForm : Form
    {
		private readonly UserRepository userRepo = new UserRepository();
		private readonly TeacherRepository teacherRepo = new TeacherRepository();
		private readonly StudentRepository studentRepo = new StudentRepository();

		public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			string login = txtLogin.Text.Trim();
			string password = txtPassword.Text.Trim();

			if (login == "" || password == "")
			{
				MessageBox.Show("Please enter login and password.");
				return;
			}

			User user = userRepo.GetByLogin(login);

			if (user == null)
			{
				MessageBox.Show("User not found.");
				return;
			}

			if (user.Password != password)
			{
				MessageBox.Show("Incorrect password.");
				return;
			}

			if (user.Role == "admin")
			{
				MessageBox.Show("Welcome, admin!");
			}
			else if (user.Role == "teacher")
			{
				MessageBox.Show("Welcome, teacher!");
			}
			else if (user.Role == "student")
			{
				MessageBox.Show("Welcome student!");
			}
		}

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
