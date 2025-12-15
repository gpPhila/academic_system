using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using academic_system;

namespace academic_system
{
    public partial class LoginForm : Form
    {
		private readonly UserRepository userRepo = new UserRepository();
		private readonly TeacherRepository teacherRepo = new TeacherRepository();
		private readonly StudentRepository studentRepo = new StudentRepository();

		public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			string login = txtLogin.Text.Trim();
			string password = txtPassword.Text.Trim();

			if (login == "" || password == "")
			{
				MessageBox.Show("Please enter login and password.");
				return;
			}

			User user = userRepo.GetByLogin(login);

			if (user == null)
			{
				MessageBox.Show("User not found.");
				return;
			}

			if (user.Password != password)
			{
				MessageBox.Show("Incorrect password.");
				return;
			}

			if (user.Role == "teacher")
			{
				MessageBox.Show("Welcome, teacher!");
			}

			var userRepository = new UserRepository();
			var studentRepository = new StudentRepository();
			var teacherRepository = new TeacherRepository();
			var groupRepository = new GroupRepository();
			var subjectRepository = new SubjectRepository();
			var gosRepository = new GOSRepository();
			var gradeRepository = new GradeRepository();
			var gossRepository = new GOSSRepository();

			AdminManager manager;
			StudentManager studentManager;
			Student currentStudent;
			TeacherManager teacherManager;
			Teacher currentTeacher;

			switch (user.Role)
			{
				case "admin":
					manager = new AdminManager(userRepository,
					studentRepository,
					teacherRepository,
					groupRepository,
					subjectRepository,
					gosRepository,
					gradeRepository,
					gossRepository);
				var adminForm = new AdminDashboard(manager, user);
				this.Hide();
				adminForm.Show();
				break;
				
				case "student":
					studentManager = new StudentManager(userRepository,
					studentRepository,
					teacherRepository,
					groupRepository,
					subjectRepository,
					gosRepository,
					gradeRepository,
					gossRepository);

					currentStudent = studentRepository.GetByUserId(user.UserId);
					var studentForm = new StudentDashboard(studentManager, user, currentStudent);
					this.Hide();
					studentForm.Show();
				break;

				case "teacher":
					teacherManager = new TeacherManager(userRepository,
					studentRepository,
					teacherRepository,
					groupRepository,
					subjectRepository,
					gosRepository,
					gradeRepository,
					gossRepository);

					currentTeacher = teacherRepository.GetByUserId(user.UserId);
					var teacherForm = new TeacherDashboard(teacherManager, user, currentTeacher);
					this.Hide();
					teacherForm.Show();
					break;

			}
		}
    }
}
