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
			if (e.RowIndex >= 0)
			{
				var row = dgvUsers.Rows[e.RowIndex];

				txtFirstName.Text = row.Cells["Login"].Value.ToString();
				txtLastName.Text = row.Cells["Password"].Value.ToString();
				cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
			}
		}

        private void btnCreate_Click(object sender, EventArgs e)
        {
			string role = cmbRole.SelectedItem?.ToString();
			string firstName = txtFirstName.Text.Trim();
			string lastName = txtLastName.Text.Trim();

			if (role == null)
			{
				MessageBox.Show("Please select a role.");
				return;
			}

			if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
			{
				MessageBox.Show("Please fill first and last name.");
				return;
			}

			string login = firstName;
			string password = lastName;

			manager.CreateUser(login, password, role);
			MessageBox.Show("User created!");

			LoadUsers();
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

			manager.UpdateUser(
				userId,
				txtFirstName.Text.Trim(),
				txtLastName.Text.Trim(),
				cmbRole.SelectedItem.ToString()
			);

			MessageBox.Show("User updated!");
			LoadUsers();
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvUsers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a user first.");
				return;
			}

			var row = dgvUsers.SelectedRows[0];
			int userId = (int)row.Cells["UserId"].Value;

			manager.DeleteUser(userId);

			MessageBox.Show("User deleted!");
			LoadUsers();
		}
    }
}
