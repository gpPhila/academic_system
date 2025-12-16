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
		private readonly Student selectedStudent;
		private readonly Subject selectedSubject;

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

			dgvSubject.AllowUserToAddRows = false;

			LoadGroups();
		}

		private void LoadGroups()
		{
			var groups = manager.GetAllGroups();

			groups.Insert(0, new Group
			{
				GroupId = -1,
				Name = "-- Select a group --"
			});

			cmbGroups.DataSource = groups;
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
			if (cmbGroups.SelectedValue == null || (int)cmbGroups.SelectedValue == -1)
			{
				MessageBox.Show("Select a group first.");
				return;
			}

			int groupId = (int)cmbGroups.SelectedValue;
			dgvSubject.DataSource = manager.GetSubjectsByGroupAndTeacher(groupId, currentTeacher.TeacherId);
			dgvSubject.Columns["SubjectId"].Visible = false;

			dgvStudent.DataSource = manager.GetStudentsByGroup(groupId);
			dgvStudent.Columns["UserId"].Visible = false;
			dgvStudent.Columns["GroupId"].Visible = false;
			dgvStudent.Columns["StudentId"].Visible = false;
		}

        private void btnGrade_Click(object sender, EventArgs e)
        {
			if (dgvStudent.SelectedRows.Count == 0 ||
				dgvSubject.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select subject and student.");
				return;
			}

			var studentRow = dgvStudent.SelectedRows[0];
			var subjectRow = dgvSubject.SelectedRows[0];

			int studentId = (int)studentRow.Cells["StudentId"].Value;
			int subjectId = (int)subjectRow.Cells["SubjectId"].Value;

			string studentFullName =
			studentRow.Cells["FirstName"].Value + " " +
			studentRow.Cells["LastName"].Value;

			string subjectName =
			subjectRow.Cells["SubjectName"].Value.ToString();

			var editor = new GradeEditorForm(manager, studentId, subjectId, currentTeacher.TeacherId, studentFullName, subjectName);
			editor.ShowDialog();
		}
    }
}
