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

		private readonly SubjectRepository subjectRepository;
		private readonly StudentRepository studentRepository;
        private readonly GradeRepository gradeRepository;

        public string gradeValue => txtGradeValue.Text.Trim();
		public GradeEditorForm(TeacherManager manager, Teacher currentTeacher, Student selectedStudent, Subject selectedSubject)
        {
            InitializeComponent();
			this.manager = manager;
			this.currentTeacher = currentTeacher;
            this.selectedStudent = selectedStudent;
			this.selectedSubject = selectedSubject;

			LoadGrades();
		}

        public void LoadGrades()
        {
			dgvGrades.DataSource = manager.ViewGradesByTeacher(currentTeacher.TeacherId);
			dgvGrades.Columns["GradeId"].Visible = false;
			dgvGrades.Columns["StudentId"].Visible = false;
			dgvGrades.Columns["SubjectId"].Visible = false;
			dgvGrades.Columns["TeacherId"].Visible = false;
			dgvGrades.AllowUserToAddRows = false;
		}

        private void GradeEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
				manager.AddGrade(selectedStudent.StudentId, selectedSubject.SubjectId, currentTeacher.TeacherId, gradeValue);
				LoadGrades();
		}
    }
}
