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
			LoadSubjects();

			cmbSubjects.SelectedIndexChanged += cmbSubjects_SelectedIndexChanged;
		}

		public void LoadSubjects()
		{
			DataTable table = manager.GetSubjectsForStudent(currentStudent.GroupId);

			DataRow row = table.NewRow();
			row["subject_id"] = -1;
			row["SubjectName"] = "-- Select a subject --";
			table.Rows.InsertAt(row, 0);

			cmbSubjects.DataSource = table;
			cmbSubjects.DisplayMember = "SubjectName";
			cmbSubjects.ValueMember = "subject_id";
		}

		private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbSubjects.SelectedValue == null)
				return;

			int subjectId = Convert.ToInt32(cmbSubjects.SelectedValue);

			// ignore "-- Select a subject --"
			if (subjectId == -1)
			{
				dgvGrades.DataSource = null;
				return;
			}

			var grades = manager.ViewGradesByStudentAndSubject(
				currentStudent.StudentId,
				subjectId
			);

			dgvGrades.DataSource = grades;

			foreach (DataGridViewColumn col in dgvGrades.Columns)
			{
				col.Visible = col.Name == "Value";
			}

			dgvGrades.Columns["Value"].HeaderText = "Grade";
			dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
