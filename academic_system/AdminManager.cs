using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IGradeRepository gradeRepository) : base(userRepository, studentRepository, teacherRepository, groupRepository, subjectRepository, gOSRepository, gradeRepository)
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
		public void DeleteUser(int userId)
		{
			userRepository.Delete(userId);
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
			studentRepository.Delete(studentId);
		}
		public void AssignStudentToGroup(int studentId, int groupId)
		{
			studentRepository.AssignStudentToGroup(studentId, groupId);
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

		public List<(string DisplayName, int Id)> GetTeachersForDropdown()
		{
			var teachers = GetAllTeachers();
			var result = new List<(string, int)>
			{
				("No teacher", 0)
			};

			result.AddRange(teachers.Select(t =>
				($"{t.FirstName} {t.LastName}", t.TeacherId)));

			return result;
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
		public void CreateGroup(string name)
		{
			var group = new Group
			{
				Name = name
			};

			groupRepository.Add(group);
		}

		public Group GetGroupById(int groupId)
		{
			return groupRepository.GetById(groupId);
		}

		public void UpdateGroup(int groupId, string name)
		{
			var group = new Group
			{
				GroupId = groupId,
				Name = name
			};

			groupRepository.Update(group);
		}

		public void DeleteGroup(int groupId)
		{
			groupRepository.Delete(groupId);
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
		public void AssignTeacherToSubject(int subjectId, int teacherId)
		{
			subjectRepository.AssignTeacherToSubject(subjectId, teacherId);
		}
		public void AssignSubjectToGroup(int groupId, int subjectId)
		{
			gOSRepository.AssignSubjectToGroup(groupId, subjectId);
		}

	}
}
