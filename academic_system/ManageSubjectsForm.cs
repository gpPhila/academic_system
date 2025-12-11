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
    public partial class ManageSubjectsForm : Form
    {
		private readonly AdminManager manager;
		public ManageSubjectsForm(AdminManager manager)
        {
            InitializeComponent();
			this.manager = manager;
			LoadSubjects();
		}

		private void LoadSubjects()
		{
			dgvSubjects.DataSource = manager.GetAllSubjects();
		}
		private void ManageSubjectsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
			var editor = new SubjectEditorForm("Create Subject", manager);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.CreateSubject(
					editor.SubjectName,
					editor.SubjectDescription,
					editor.SelectedTeacherId  
				);

				LoadSubjects();
			}
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			if (dgvSubjects.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a subject first.");
				return;
			}

			var row = dgvSubjects.SelectedRows[0];
			int subjectId = (int)row.Cells["SubjectId"].Value;

			Subject subject = manager.GetSubjectById(subjectId);

			var editor = new SubjectEditorForm("Update Subject", manager, subject);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.UpdateSubject(
					subjectId,
					editor.SelectedTeacherId,
					editor.SubjectName,
					editor.SubjectDescription
				);

				LoadSubjects();
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvSubjects.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a subject first.");
				return;
			}

			var confirm = MessageBox.Show(
				"Are you sure you want to delete this subject?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm != DialogResult.Yes)
				return;

			var row = dgvSubjects.SelectedRows[0];
			int subjectId = (int)row.Cells["SubjectId"].Value;

			manager.DeleteSubject(subjectId);

			LoadSubjects();
		}
    }
}
