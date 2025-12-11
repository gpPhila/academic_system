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
    public partial class ManageStudentGroupsForm : Form
    {
		private readonly AdminManager manager;
		public ManageStudentGroupsForm(AdminManager manager)
        {
            InitializeComponent();
            this.manager = manager;

            LoadGroups();
        }
        private void LoadGroups() 
        {
			dgvGroups.DataSource = manager.GetAllGroups();
		}

        private void btnCreate_Click(object sender, EventArgs e)
        {
			var editor = new StudentGroupsEditorForm("Create Group");

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.CreateGroup(editor.GroupName);
				LoadGroups();
			}
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			if (dgvGroups.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a group first.");
				return;
			}

			var row = dgvGroups.SelectedRows[0];
			int groupId = (int)row.Cells["GroupId"].Value;

			Group group = manager.GetGroupById(groupId);

			var editor = new StudentGroupsEditorForm("Update Group", group);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.UpdateGroup(
					groupId,
					editor.GroupName
				);

				LoadGroups();
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvGroups.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a group first.");
				return;
			}

			var confirm = MessageBox.Show(
				"Are you sure you want to delete this group?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm != DialogResult.Yes)
				return;

			var row = dgvGroups.SelectedRows[0];
			int groupId = (int)row.Cells["GroupId"].Value;

			manager.DeleteGroup(groupId);
			LoadGroups();
		}
    }
}
