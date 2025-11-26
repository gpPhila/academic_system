using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using academic_system;

namespace academic_system
{
	public class BaseManager
	{
		private readonly IUserRepository userRepository;
		private readonly IStudentRepository studentRepository;
		private readonly ITeacherRepository teacherRepository;
		private readonly IGroupRepository groupRepository;
		private readonly ISubjectRepository subjectRepository;
		private readonly IGOSRepository gOSRepository;
		private readonly IGradeRepository gradeRepository;

		// constructor
		public BaseManager(
			IUserRepository userRepository,
			IStudentRepository studentRepository,
			ITeacherRepository teacherRepository,
			IGroupRepository groupRepository,
			ISubjectRepository subjectRepository,
			IGOSRepository gOSRepository,
			IGradeRepository gradeRepository)
		{
			this.userRepository = userRepository;
			this.studentRepository = studentRepository;
			this.teacherRepository = teacherRepository;
			this.groupRepository = groupRepository;
			this.subjectRepository = subjectRepository;
			this.gOSRepository = gOSRepository;
			this.gradeRepository = gradeRepository;
		}

		// ---- USER METHODS ----
		/*
		public User GetUserById(int id)
		{
			return userRepository.GetById(id);
		}
		*/

		public int CreateUser(string login, string password, string role)
		{
			var user = new User
			{
				Login = login,
				Password = password,
				Role = role
			};

			userRepository.Add(user);
			var createdUser = userRepository.GetByLogin(login);
			return createdUser.UserId;
		}


		// ---- STUDENT METHODS ----

		public void CreateStudent(int groupId, string firstName, string lastName)
		{
			int newUserId = CreateUser(firstName, lastName, "student");
			var student = new Student
			{
				UserId = newUserId,
				GroupId = groupId,
				FirstName = firstName,
				LastName = lastName
			};

			studentRepository.Add(student);
		}

		public void UpdateStudent() { }
		public void DeleteStudent(int studentId)
		{
			studentRepository.Delete(studentId);
		}

		public List<Student> GetStudentsByGroup(int groupId)
		{
			return studentRepository.GetByGroupId(groupId);
		}

		public List<Student> GetAllStudents()
		{
			return studentRepository.GetAll();
		}

		public void AssignStudentToGroup(int studentId, int groupId)
		{
			studentRepository.AssigntStudentToGroup(studentId, groupId);
		}

		// ---- TEACHER METHODS ----

		public void CreateTeacher(int userId, string firstName, string lastName)
		{
			int newUserId = CreateUser(firstName, lastName, "teacher");
			var teacher = new Teacher
			{
				UserId = userId,
				FirstName = firstName,
				LastName = lastName
			};

			teacherRepository.Add(teacher);
		}

		public void UpdateTeacher() { }

		public void DeleteTeacher(int teacherId)
		{
			teacherRepository.Delete(teacherId);
		}

		public List <Teacher> GetAllTeachers()
		{
			return teacherRepository.GetAll();
		}

		// ---- GROUP METHODS ----

		public void CreateGroup(string name)
		{
			var group = new Group
			{
				Name = name
			};

			groupRepository.Add(group);
		}

		public void DeleteGroup(int groupId)
		{
			groupRepository.Delete(groupId);
		}

		public List <Group> GetAllGroups()
		{
			return groupRepository.GetAll();
		}

		// ---- SUBJECT METHODS ----

		public void CreateSubject(string name, string description)
		{
			var subject = new Subject
			{
				Name = name,
				Description = description
			};

			subjectRepository.Add(subject);
		}

		public void UpdateSubject() { }

		public void DeleteSubject(int subjectId)
		{
			subjectRepository.Delete(subjectId);
		}

		public List <Subject> GetAllSubjects()
		{
			return subjectRepository.GetAll();
		}

		public List<Subject> GetByTeacherId(int teacherId)
		{
			return subjectRepository.GetByTeacherId(teacherId);
		}

		public void AssignTeacherToSubject(int subjectId, int teacherId)
		{
			subjectRepository.AssignTeacherToSubject(subjectId, teacherId);
		}
		public void AssignSubjectToGroup(int groupId, int subjectId)
		{
			gOSRepository.AssignSubjectToGroup(groupId, subjectId);
		}

		// ---- GRADE METHODS ----

		public void AddGrade(int studentId, int subjectId, int teacherId, string value)
		{
			var grade = new Grade
			{
				StudentId = studentId,
				SubjectId = subjectId,
				TeacherId = teacherId,
				Value = value
			};

			gradeRepository.Add(grade);
		}

		public void EditGrade(int gradeId, string newValue)
		{
			//do this lol kek
		}

		public void DeleteGrade(int gradeId)
		{
			gradeRepository.Delete(gradeId);
		}

		public List <Grade> ViewGradesByStudent(int studentId)
		{
			return gradeRepository.GetByStudentId(studentId);
		}

		public List <Grade> ViewGradesByTeacher(int teacherId)
		{
			return gradeRepository.GetByTeacherId(teacherId);
		}

	}
}
