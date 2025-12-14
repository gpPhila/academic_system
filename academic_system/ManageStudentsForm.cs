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
    public partial class ManageStudentsForm : Form
    {
		private readonly AdminManager manager;
		public ManageStudentsForm(AdminManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            LoadStudents();
        }
		private void LoadStudents()
		{
			dgvStudents.DataSource = manager.GetAllStudents();
		}

		private void btnCreate_Click(object sender, EventArgs e)
        {
			var editor = new StudentEditorForm("Create Student", manager);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.CreateStudent(editor.SelectedGroupId, editor.FirstName, editor.LastName);
				LoadStudents();
			}
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			if (dgvStudents.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a student first.");
				return;
			}

			var row = dgvStudents.SelectedRows[0];
			int studentId = (int)row.Cells["StudentId"].Value;

			Student student = manager.GetStudentById(studentId);

			var editor = new StudentEditorForm("Update Student", manager, student);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.UpdateStudent(
					studentId,
					editor.SelectedGroupId,
					editor.FirstName,
					editor.LastName
				);

				LoadStudents();
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvStudents.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a student first.");
				return;
			}

			var confirm = MessageBox.Show(
				"Are you sure you want to delete this student?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm != DialogResult.Yes)
				return;

			var row = dgvStudents.SelectedRows[0];
			int studentId = (int)row.Cells["StudentId"].Value;

			manager.DeleteStudent(studentId);
			LoadStudents();
		}
    }
}
