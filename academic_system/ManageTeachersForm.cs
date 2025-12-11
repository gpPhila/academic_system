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
    public partial class ManageTeachersForm : Form
    {
		private readonly AdminManager manager;
		public ManageTeachersForm(AdminManager manager)
        {
            InitializeComponent();

			this.manager = manager;
			LoadTeachers();
		}
		private void LoadTeachers()
		{
			dgvTeachers.DataSource = manager.GetAllTeachers();
		}

		private void btnCreate_Click(object sender, EventArgs e)
        {
			var editor = new TeacherEditorForm("Create Teacher");

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.CreateTeacher(editor.FirstName, editor.LastName);
				LoadTeachers();
			}
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			if (dgvTeachers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a teacher first.");
				return;
			}

			var row = dgvTeachers.SelectedRows[0];
			int teacherId = (int)row.Cells["TeacherId"].Value;

			Teacher teacher = manager.GetTeacherById(teacherId);

			var editor = new TeacherEditorForm("Update Teacher", teacher);

			if (editor.ShowDialog() == DialogResult.OK)
			{
				manager.UpdateTeacher(
					teacherId,
					editor.FirstName,
					editor.LastName
				);

				LoadTeachers();
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvTeachers.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a teacher first.");
				return;
			}

			var confirm = MessageBox.Show(
				"Are you sure you want to delete this teacher?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning
			);

			if (confirm != DialogResult.Yes)
				return;

			var row = dgvTeachers.SelectedRows[0];
			int teacherId = (int)row.Cells["TeacherId"].Value;

			manager.DeleteTeacher(teacherId);
			LoadTeachers();
		}

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
