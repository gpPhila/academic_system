using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Reflection;

namespace academic_system
{
    public partial class GradeEditorForm : Form
    {
		private readonly TeacherManager manager;
        private readonly Teacher currentTeacher;
        private readonly Student selectedStudent;
        private readonly Subject selectedSubject;

		private readonly int studentId;
		private readonly int subjectId;
		private readonly int teacherId;

		private readonly string studentFullName;
		private readonly string subjectName;

		public string gradeValue => txtGradeValue.Text.Trim();
		public GradeEditorForm(TeacherManager manager,
		int studentId,
		int subjectId,
		int teacherId,
		string studentFullName,
		string subjectName)
        {
            InitializeComponent();
			this.manager = manager;
			this.studentId = studentId;
			this.subjectId = subjectId;
			this.teacherId = teacherId;

			this.studentFullName = studentFullName;
			this.subjectName = subjectName;

			txtStudentName.Text = studentFullName;
			txtSubjectName.Text = subjectName;

			txtStudentName.ReadOnly = true;
			txtSubjectName.ReadOnly = true;

			LoadGrades();
		}

        public void LoadGrades()
        {
			dgvGrades.DataSource = manager.GetGrades(
			studentId,
			subjectId,
			teacherId);

			dgvGrades.Columns["GradeId"].Visible = false;
			//dgvGrades.Columns["StudentId"].Visible = false;
			//dgvGrades.Columns["SubjectId"].Visible = false;
			//dgvGrades.Columns["TeacherId"].Visible = false;
			dgvGrades.AllowUserToAddRows = false;
		}
		private bool IsValidGrade(out int grade)
		{
			grade = 0;

			if (string.IsNullOrWhiteSpace(txtGradeValue.Text))
			{
				MessageBox.Show("Please enter a grade.");
				return false;
			}

			if (!int.TryParse(txtGradeValue.Text.Trim(), out grade) || grade < 1 || grade > 10)
			{
				MessageBox.Show("Grade must be between 1 and 10.");
				return false;
			}

			return true;
		}


		private void GradeEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
			DialogResult = DialogResult.Cancel;
			Close();
		}

        private void btnAdd_Click(object sender, EventArgs e)
        {
			if (!IsValidGrade(out int grade)) return;

			manager.AddGrade(studentId, subjectId, teacherId, gradeValue);
			LoadGrades();
			txtGradeValue.Clear();
		}

        private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dgvGrades.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a grade first.");
				return;
			}

			if (!IsValidGrade(out int grade)) return;

			int gradeId = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["GradeId"].Value);

			manager.EditGrade(gradeId, grade.ToString());
			LoadGrades();
			txtGradeValue.Clear();
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			if (dgvGrades.SelectedRows.Count == 0)
			{
				MessageBox.Show("Select a grade first.");
				return;
			}

			int gradeId = (int)dgvGrades.SelectedRows[0].Cells["GradeId"].Value;

			if (MessageBox.Show(
				"Delete selected grade?",
				"Confirm",
				MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				manager.DeleteGrade(gradeId);
				LoadGrades();
				txtGradeValue.Clear();
			}
		}
    }
}
