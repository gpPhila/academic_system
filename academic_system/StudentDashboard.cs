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
    public partial class StudentDashboard : Form
    {
		private readonly StudentManager manager;
		private readonly User currentUser;
        private readonly Student currentStudent;
		public string FirstName => txtFirstName.Text.Trim();
		public string LastName => txtLastName.Text.Trim();
		public StudentDashboard(StudentManager manager, User currentUser, Student currentStudent)
        {
            InitializeComponent();
            this.manager = manager;
            this.currentUser = currentUser;
			this.currentStudent = currentStudent;
			
			LoadGroupName();
			txtFirstName.Enabled = false;
			txtLastName.Enabled = false;
			txtGroup.Enabled = false;

			txtFirstName.Text = currentStudent.FirstName;
			txtLastName.Text = currentStudent.LastName;
		}
		private void LoadGroupName()
		{
			var group = manager.GroupRepository.GetById(currentStudent.GroupId);
			txtGroup.Text = group?.Name ?? "Unknown group";
		}


		private void btnManageAcc_Click(object sender, EventArgs e)
        {
			var form = new ManageAccountForm(currentUser, manager.UserRepository);
			form.ShowDialog();
		}

        private void btnLogOut_Click(object sender, EventArgs e)
        {
			var LoginForm = new LoginForm();
			this.Close();
			LoginForm.Show();
		}
    }
}
