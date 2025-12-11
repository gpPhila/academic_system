using System;
using System.Windows.Forms;

namespace academic_system
{
    public partial class ManageUsersForm : Form
    {
		private readonly AdminManager manager;
		public ManageUsersForm(AdminManager manager)
        {
            InitializeComponent();
            this.manager = manager;
			LoadUsers();
		}
		private void LoadUsers()
		{
			var users = manager.GetAllUsers();
			dgvUsers.DataSource = users;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
		}

        private void btnCreate_Click(object sender, EventArgs e)
        {
			var editor = new UserEditorForm("Create");

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.CreateUser(
					editor.LoginValue,
					editor.PasswordValue,
					editor.RoleValue
				);
				LoadUsers();
			}
		}


		private void btnUpdate_Click(object sender, EventArgs e)
        {

			if (dgvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a user first.");
				return;
			}

			var row = dgvUsers.SelectedRows[0];
			int userId = (int)row.Cells["UserId"].Value;

			var existingUser = new User
			{
				UserId = userId,
				Login = row.Cells["Login"].Value.ToString(),
				Password = row.Cells["Password"].Value.ToString(),
				Role = row.Cells["Role"].Value.ToString()
			};

			var editor = new UserEditorForm("Edit User", existingUser);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.UpdateUser(
					userId,
					editor.LoginValue,
					editor.PasswordValue,
					editor.RoleValue
				);

				LoadUsers();
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a user first.");
				return;
			}

			var confirm = MessageBox.Show(
			"Are you sure you want to delete this user?",
			"Confirm Delete",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Warning);

			if (confirm != DialogResult.Yes)
				return;

			var row = dgvUsers.SelectedRows[0];
			int userId = (int)row.Cells["UserId"].Value;

			manager.DeleteUser(userId);

			MessageBox.Show("User deleted!");
			LoadUsers();
		}

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
