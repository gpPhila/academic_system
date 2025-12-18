using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using academic_system;

namespace academic_system
{
	/// <summary>
	/// Bazine klasė, iš kurios paveldi kiti valdikliai (manageriai).
	/// </summary>
	public class BaseManager
	{
		protected readonly IUserRepository userRepository;
		protected readonly IStudentRepository studentRepository;
		protected readonly ITeacherRepository teacherRepository;
		protected readonly IGroupRepository groupRepository;
		protected readonly ISubjectRepository subjectRepository;
		protected readonly IGOSRepository gOSRepository;
		protected readonly IGradeRepository gradeRepository;
		protected readonly IGOSSRepository gOSSRepository;

		/// <summary>
		/// Sukuria BaseManager objektą.
		/// </summary>
		public BaseManager(
			IUserRepository userRepository,
			IStudentRepository studentRepository,
			ITeacherRepository teacherRepository,
			IGroupRepository groupRepository,
			ISubjectRepository subjectRepository,
			IGOSRepository gOSRepository,
			IGradeRepository gradeRepository,
			IGOSSRepository gOSSRepository)
		{
			this.userRepository = userRepository;
			this.studentRepository = studentRepository;
			this.teacherRepository = teacherRepository;
			this.groupRepository = groupRepository;
			this.subjectRepository = subjectRepository;
			this.gOSRepository = gOSRepository;
			this.gradeRepository = gradeRepository;
			this.gOSSRepository = gOSSRepository;
		}
		public IUserRepository UserRepository => userRepository;
		public IStudentRepository StudentRepository => studentRepository;
		public ITeacherRepository TeacherRepository => teacherRepository;
		public IGroupRepository GroupRepository => groupRepository;
		public ISubjectRepository SubjectRepository => subjectRepository;
		public IGOSRepository GOSRepository => gOSRepository;
		public IGradeRepository GradeRepository => gradeRepository;
		public IGOSSRepository GOSSRepository => gOSSRepository;

		/// <summary>
		/// Gauna studentų sąrašą pagal studentų grupės ID.
		/// </summary>
		public virtual List<Student> GetStudentsByGroup(int groupId)
		{
			return studentRepository.GetByGroupId(groupId);
		}
		/// <summary>
		/// Gauna studentų sąrašą.
		/// </summary>
		public virtual List<Student> GetAllStudents()
		{
			return studentRepository.GetAll();
		}
		/// <summary>
		/// Gauna studentų grupių sąrašą.
		/// </summary>
		public virtual List <Group> GetAllGroups()
		{
			return groupRepository.GetAll();
		}
		/// <summary>
		/// Gauna dalykų sąrašą.
		/// </summary>
		public virtual List <Subject> GetAllSubjects()
		{
			return subjectRepository.GetAll();
		}
	}
}
