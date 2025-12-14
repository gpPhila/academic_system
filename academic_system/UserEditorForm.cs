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
    public partial class UserEditorForm : Form
    {
		private readonly User selectedUser;
		public string LoginValue => txtLogin.Text.Trim();
		public string PasswordValue => txtPassword.Text.Trim();
		public string RoleValue => selectedUser.Role;
		public UserEditorForm(string title, User selectedUser)
        {
            InitializeComponent();
			this.Text = title;
			this.selectedUser = selectedUser;

			LoadRoles();

			cmbRoles.SelectedItem = selectedUser.Role;
			cmbRoles.Enabled = false;

			txtLogin.Text = selectedUser.Login;
			txtPassword.Text = selectedUser.Password;
		}
		private void LoadRoles()
		{
			cmbRoles.Items.Clear();
			cmbRoles.Items.Add("admin");
			cmbRoles.Items.Add("teacher");
			cmbRoles.Items.Add("student");
		}


		private void btnSave_Click(object sender, EventArgs e)
        {	
				if (string.IsNullOrEmpty(LoginValue) ||
					string.IsNullOrEmpty(PasswordValue))
				{
					MessageBox.Show("Login and password cannot be empty.");
					return;
				}

			DialogResult = DialogResult.OK;
			Close();
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
			Close();
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
