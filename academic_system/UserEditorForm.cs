using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace academic_system
{
    public partial class UserEditorForm : Form
    {
		public string RoleValue => cmbRole.SelectedItem?.ToString();
		public string FirstNameValue => txtFirstName.Text.Trim();
		public string LastNameValue => txtLastName.Text.Trim();
		public string LoginValue => txtLogin.Text.Trim();
		public string PasswordValue => txtPassword.Text.Trim();
		private readonly bool isUpdateMode;
		public UserEditorForm(string title, User existingUser = null)
        {
            InitializeComponent();
			this.Text = title;

			isUpdateMode = existingUser != null;

			if (isUpdateMode)
			{
				txtFirstName.Enabled = false;
				txtLastName.Enabled = false;

				txtLogin.Text = existingUser.Login;
				txtPassword.Text = existingUser.Password;
				cmbRole.SelectedItem = existingUser.Role;
			}
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			if (!isUpdateMode)
			{
				if (string.IsNullOrEmpty(FirstNameValue) ||
					string.IsNullOrEmpty(LastNameValue))
				{
					MessageBox.Show("Please fill first and last name.");
					return;
				}

				txtLogin.Text = FirstNameValue.ToLower();
				txtPassword.Text = LastNameValue.ToLower();
			}
			if (RoleValue == null)
			{
				MessageBox.Show("Select a role.");
				return;
			}

			if (isUpdateMode)
			{
				if (string.IsNullOrEmpty(LoginValue) ||
					string.IsNullOrEmpty(PasswordValue))
				{
					MessageBox.Show("Login and password cannot be empty.");
					return;
				}
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
    }
}
