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
    public partial class ManageSubjectGroupsForm : Form
    {
		private readonly AdminManager manager;
		public ManageSubjectGroupsForm(AdminManager manager)
        {
            InitializeComponent();
            this.manager = manager;

            LoadGOS();
        }

		private void LoadGOS()
		{
			dgvSubjectGroups.DataSource = manager.GetAllGOS();
		}

		private void btnCreate_Click(object sender, EventArgs e)
        {
			var editor = new SubjectGroupsEditorForm("Create Group");

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.CreateGOS(editor.GOSName);
				LoadGOS();
			}
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			if (dgvSubjectGroups.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a group of subjects first.");
				return;
			}

			var row = dgvSubjectGroups.SelectedRows[0];
			int gosId = (int)row.Cells["GOSId"].Value;

			GroupOfSubjects gos = manager.GetGOSById(gosId);

			var editor = new SubjectGroupsEditorForm("Update Group", gos);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.UpdateGOS(
					gosId,
					editor.GOSName
				);

				LoadGOS();
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvSubjectGroups.SelectedRows.Count == 0)
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

			var row = dgvSubjectGroups.SelectedRows[0];
			int gosId = (int)row.Cells["GOSId"].Value;

			manager.DeleteGOS(gosId);

			LoadGOS();
		}

        private void btnAddSubjects_Click(object sender, EventArgs e)
        {
			if (dgvSubjectGroups.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a subject group first.");
				return;
			}

			var row = dgvSubjectGroups.SelectedRows[0];
			int gosId = (int)row.Cells["GOSId"].Value;

			GroupOfSubjects gos = manager.GetGOSById(gosId);

			var form = new SubjectGroupContentForm(manager, gos);
			form.ShowDialog();
		}
    }
}
