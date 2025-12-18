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
	/// <summary>
	/// Administratoriaus valdymo logika.
	/// </summary>
	public class AdminManager : BaseManager
    {
		/// <summary>
		/// Sukuria AdminManager objektą.
		/// </summary>
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
		/// <summary>
		/// Gauna visų naudotojų sąrašą.
		/// </summary>
		public List<User> GetAllUsers()
		{
			return userRepository.GetAll();
		}
		/// <summary>
		/// Sukuria naują naudotoją.
		/// </summary>
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
		/// <summary>
		/// Atnaujina naudotojo duomenis.
		/// </summary>
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
		/// <summary>
		/// Sukuria naują studentą.
		/// </summary>
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
		/// <summary>
		/// Gauna studentą pagal jo ID.
		/// </summary>
		public Student GetStudentById(int studentId)
		{
			return studentRepository.GetById(studentId);
		}
		/// <summary>
		/// Atnaujina studento duomenis.
		/// </summary>
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
		/// <summary>
		/// Ištrina studentą ir jo vartotojo paskyrą.
		/// </summary>
		public void DeleteStudent(int studentId)
		{
			Student s = studentRepository.GetById(studentId);
			int userId = s.UserId;
		
			studentRepository.Delete(studentId);
			userRepository.Delete(userId);
		}
		/// <summary>
		/// Sukuria naują dėstytoją.
		/// </summary>
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
		/// <summary>
		/// Atnaujina dėstytojo duomenis.
		/// </summary>
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
		/// <summary>
		/// Gauna dėstytoją pagal jo ID.
		/// </summary>
		public Teacher GetTeacherById(int teacherId) 
		{
			return teacherRepository.GetById(teacherId);
		}
		/// <summary>
		/// Ištrina dėstytoją ir jo naudotojo paskyrą.
		/// </summary>
		public void DeleteTeacher(int teacherId)
		{
			Teacher t = teacherRepository.GetById(teacherId);
			int userId = t.UserId;
			teacherRepository.Delete(teacherId);
			userRepository.Delete(userId);
		}
		/// <summary>
		/// Gauna dėstytojų sąrašą.
		/// </summary>
		public List<Teacher> GetAllTeachers()
		{
			return teacherRepository.GetAll();
		}
		/// <summary>
		/// Gauna dalykų grupių sąrašą.
		/// </summary>
		public List<GroupOfSubjects> GetAllGOS() 
		{
			return gOSRepository.GetAll();
		}
		/// <summary>
		/// Sukuria studentų grupę.
		/// </summary>
		public void CreateGroup(string name, int? gosId)
		{
			var group = new Group
			{
				Name = name,
				GosId = gosId
			};

			groupRepository.Add(group);
		}
		/// <summary>
		/// Gauna studentų grupę pagal jos ID.
		/// </summary>
		public Group GetGroupById(int groupId)
		{
			return groupRepository.GetById(groupId);
		}
		/// <summary>
		/// Atnaujina studentų grupės duomenis.
		/// </summary>
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
		/// <summary>
		/// Ištrina studentų grupę.
		/// </summary>
		public void DeleteGroup(int groupId)
		{
			groupRepository.Delete(groupId);
		}
		/// <summary>
		/// Sukuria dalykų grupę.
		/// </summary>
		public void CreateGOS(string name)
		{
			var gos = new GroupOfSubjects
			{
				Name = name
			};

			gOSRepository.Add(gos);
		}
		/// <summary>
		/// Gauna dalykų grupę pagal jos ID.
		/// </summary>
		public GroupOfSubjects GetGOSById(int gosId)
		{
			return gOSRepository.GetById(gosId);
		}
		/// <summary>
		/// Atnaujina dalykų grupės duomenis.
		/// </summary>
		public void UpdateGOS(int gosId, string name)
		{
			var gos = new GroupOfSubjects
			{
				GOSId = gosId,
				Name = name
			};

			GOSRepository.Update(gos);
		}
		/// <summary>
		/// Ištrina dalykų grupę.
		/// </summary>
		public void DeleteGOS(int gosId)
		{
			gOSRepository.Delete(gosId);
		}
		/// <summary>
		/// Prideda dalyką prie dalykų grupės.
		/// </summary>
		public void AddGOSS(int gosId, int subjectId)
		{
			var goss = new GOS_Subject
			{
				GosId = gosId,
				SubjectId = subjectId
			};

			gOSSRepository.Add(goss);
		}
		/// <summary>
		/// Ištrina dalyką iš dalykų grupės.
		/// </summary>
		public void DeleteGOSS(int gossid)
		{
			gOSSRepository.Delete(gossid);
		}
		/// <summary>
		/// Gauna dalykų pavadinimus pagal dalykų grupės ID.
		/// </summary>
		public DataTable GetGOSSByGosIdWithSubjectName(int gosId)
		{
			return gOSSRepository.GetByGosIdWithSubjectName(gosId);
		}
		/// <summary>
		/// Sukuria naują dalyką.
		/// </summary>
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
		/// <summary>
		/// Atnaujina dalyko duomenis.
		/// </summary>
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
		/// <summary>
		/// Gauna dalyką pagal dalyko ID.
		/// </summary>
		public Subject GetSubjectById(int subjectId)
		{
			return subjectRepository.GetById(subjectId);
		}
		/// <summary>
		/// Ištrina dalyką.
		/// </summary>
		public void DeleteSubject(int subjectId)
		{
			subjectRepository.Delete(subjectId);
		}
	}
}
