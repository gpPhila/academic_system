using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using academic_system;

namespace academic_system
{
    public class AdminManager : BaseManager
    {
        public AdminManager(
            IUserRepository userRepository,
            IStudentRepository studentRepository,
            ITeacherRepository teacherRepository,
            IGroupRepository groupRepository,
            ISubjectRepository subjectRepository,
            IGOSRepository gOSRepository,
            IGradeRepository gradeRepository,
			IGOSSRepository gOSSRepository) : base(userRepository, studentRepository, teacherRepository, groupRepository, subjectRepository, gOSRepository, gradeRepository, gOSSRepository)
        {}
		public List<User> GetAllUsers()
		{
			return userRepository.GetAll();
		}
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

		public void UpdateUser(int userId, string login, string password, string role)
		{
			var user = new User
			{
				UserId = userId,
				Login = login,
				Password = password,
				Role = role
			};

			userRepository.Update(user);
		}
		public void CreateStudent(int groupId, string firstName, string lastName)
		{
			int newUserId = CreateUser(firstName.ToLower(), lastName.ToLower(), "student");
			var student = new Student
			{
				UserId = newUserId,
				GroupId = groupId,
				FirstName = firstName,
				LastName = lastName
			};

			studentRepository.Add(student);
		}
		public Student GetStudentById(int studentId)
		{
			return studentRepository.GetById(studentId);
		}
		public void UpdateStudent(int studentId, int groupId, string firstName, string lastName)
		{
			var student = new Student
			{
				StudentId = studentId,
				GroupId = groupId,
				FirstName = firstName,
				LastName = lastName
			};

			studentRepository.Update(student);
		}
		public void DeleteStudent(int studentId)
		{
			Student s = studentRepository.GetById(studentId);
			int userId = s.UserId;
		
			studentRepository.Delete(studentId);
			userRepository.Delete(userId);
		}
		public void CreateTeacher(string firstName, string lastName)
		{
			int newUserId = CreateUser(firstName.ToLower(), lastName.ToLower(), "Teacher");
			var teacher = new Teacher
			{
				UserId = newUserId,
				FirstName = firstName,
				LastName = lastName
			};

			teacherRepository.Add(teacher);
		}

		public void UpdateTeacher(int teacherId, string firstName, string lastName)
		{
			var teacher = new Teacher
			{
				TeacherId = teacherId,
				FirstName = firstName,
				LastName = lastName
			};

			teacherRepository.Update(teacher);
		}

		public Teacher GetTeacherById(int teacherId) 
		{
			return teacherRepository.GetById(teacherId);
		}
		public void DeleteTeacher(int teacherId)
		{
			Teacher t = teacherRepository.GetById(teacherId);
			int userId = t.UserId;
			teacherRepository.Delete(teacherId);
			userRepository.Delete(userId);
		}
		public List<Teacher> GetAllTeachers()
		{
			return teacherRepository.GetAll();
		}

		public List<GroupOfSubjects> GetAllGOS() 
		{
			return gOSRepository.GetAll();
		}

		public void CreateGroup(string name, int? gosId)
		{
			var group = new Group
			{
				Name = name,
				GosId = gosId
			};

			groupRepository.Add(group);
		}
		public Group GetGroupById(int groupId)
		{
			return groupRepository.GetById(groupId);
		}

		public void UpdateGroup(int groupId, string name, int? gosId)
		{
			var group = new Group
			{
				GroupId = groupId,
				Name = name,
				GosId= gosId
			};

			groupRepository.Update(group);
		}

		public void DeleteGroup(int groupId)
		{
			groupRepository.Delete(groupId);
		}

		public void CreateGOS(string name)
		{
			var gos = new GroupOfSubjects
			{
				Name = name
			};

			gOSRepository.Add(gos);
		}

		public GroupOfSubjects GetGOSById(int gosId)
		{
			return gOSRepository.GetById(gosId);
		}

		public void UpdateGOS(int gosId, string name)
		{
			var gos = new GroupOfSubjects
			{
				GOSId = gosId,
				Name = name
			};

			GOSRepository.Update(gos);
		}
		public void DeleteGOS(int gosId)
		{
			gOSRepository.Delete(gosId);
		}
		public void AddGOSS(int gosId, int subjectId)
		{
			var goss = new GOS_Subject
			{
				GosId = gosId,
				SubjectId = subjectId
			};

			gOSSRepository.Add(goss);
		}
		public void DeleteGOSS(int gossid)
		{
			gOSSRepository.Delete(gossid);
		}
		public DataTable GetGOSSByGosIdWithSubjectName(int gosId)
		{
			return gOSSRepository.GetByGosIdWithSubjectName(gosId);
		}
		public void CreateSubject(string name, string description, int teacherId)
		{
			var subject = new Subject
			{
				Name = name,
				Description = description,
				TeacherId = teacherId
			};

			subjectRepository.Add(subject);
		}

		public void UpdateSubject(int subjectId, int teacherId, string name, string description)
		{
			var subject = new Subject
			{
				SubjectId = subjectId,
				TeacherId = teacherId,
				Name = name,
				Description = description
			};

			subjectRepository.Update(subject);
		}
		public Subject GetSubjectById(int subjectId)
		{
			return subjectRepository.GetById(subjectId);
		}
		public void DeleteSubject(int subjectId)
		{
			subjectRepository.Delete(subjectId);
		}
	}
}
