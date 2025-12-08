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
    public partial class AdminDashboard : Form
    {
		private AdminManager manager;
		private User currentUser;
		public AdminDashboard(AdminManager manager, User user)
        {
            InitializeComponent();
			this.manager = manager;
			this.currentUser = user;
		}

        private void button7_Click(object sender, EventArgs e)
        {
			var LoginForm = new LoginForm();
			this.Close();
            LoginForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
			var form = new ManageAccountForm(currentUser, manager.UserRepository);
			form.ShowDialog();
		}

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            var form = new ManageUsersForm(manager);
            form.ShowDialog();
        }
    }
}
