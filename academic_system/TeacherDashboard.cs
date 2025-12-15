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
    public partial class TeacherDashboard : Form
    {
		private readonly TeacherManager manager;
		private readonly User currentUser;
		private readonly Teacher currentTeacher;

		private readonly GroupRepository groupRepository;
		private readonly SubjectRepository subjectRepository;
		private readonly StudentRepository studentRepository;

		public string FirstName => txtFirstName.Text.Trim();
		public string LastName => txtLastName.Text.Trim();
		public TeacherDashboard(TeacherManager manager, User currentUser, Teacher currentTeacher)
		{
            InitializeComponent();
			this.manager = manager;
			this.currentUser = currentUser;
			this.currentTeacher = currentTeacher;

			txtFirstName.Enabled = false;
			txtLastName.Enabled = false;

			txtFirstName.Text = currentTeacher.FirstName;
			txtLastName.Text = currentTeacher.LastName;

			LoadGroups();
		}

		private void LoadGroups()
		{
			cmbGroups.DataSource = manager.GetAllGroups();
			cmbGroups.DisplayMember = "Name";
			cmbGroups.ValueMember = "GroupId";
		}

		private void TeacherDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
			int groupId = (int)cmbGroups.SelectedValue;

			dgvSubject.DataSource = manager.GetSubjectsByGroup(groupId);
		}

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
			if (dgvSubject.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a subject.");
				return;
			}

			int groupId = (int)cmbGroups.SelectedValue;

			dgvStudent.DataSource = manager.GetStudentsByGroup(groupId);
		}

        private void btnGrade_Click(object sender, EventArgs e)
        {
			if (dgvStudent.SelectedRows.Count == 0 ||
				dgvSubject.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select subject and student.");
				return;
			}

			int studentId =
				(int)dgvStudent.SelectedRows[0].Cells["StudentId"].Value;

			int subjectId =
				(int)dgvSubject.SelectedRows[0].Cells["SubjectId"].Value;

			var editor = new GradeEditorForm(studentId, subjectId);
			editor.ShowDialog();
		}
    }
}
