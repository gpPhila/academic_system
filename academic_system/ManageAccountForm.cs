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
    public partial class ManageAccountForm : Form
    {
		private readonly User currentUser;
		private readonly IUserRepository userRepository;
		public ManageAccountForm(User user, IUserRepository userRepository)
        {
            InitializeComponent();

			this.currentUser = user;
			this.userRepository = userRepository;

			textBox1.Text = currentUser.Login;
			textBox1.Enabled = false;
		}

        private void btnSave(object sender, EventArgs e)
        {
			string newPassword = textBox2.Text.Trim();
			string confirmPassword = textBox3.Text.Trim();

			if (string.IsNullOrEmpty(newPassword))
			{
				MessageBox.Show("Please enter a new password.");
				return;
			}

			if (newPassword != confirmPassword)
			{
				MessageBox.Show("Passwords do not match.");
				return;
			}

			currentUser.Password = newPassword;
			userRepository.Update(currentUser);

			MessageBox.Show("Password updated successfully!");
			this.Close();
		}
    }
}
