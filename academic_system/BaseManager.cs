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
		protected readonly IUserRepository userRepository;
		protected readonly IStudentRepository studentRepository;
		protected readonly ITeacherRepository teacherRepository;
		protected readonly IGroupRepository groupRepository;
		protected readonly ISubjectRepository subjectRepository;
		protected readonly IGOSRepository gOSRepository;
		protected readonly IGradeRepository gradeRepository;

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
		/*
		public User GetUserById(int id)
		{
			return userRepository.GetById(id);
		}
		*/

		public virtual void UpdatePasswordByUser(int userId, string newPassword)
		{
			userRepository.UpdatePassword(userId, newPassword);
		}

		public virtual List<Student> GetStudentsByGroup(int groupId)
		{
			return studentRepository.GetByGroupId(groupId);
		}

		public virtual List<Student> GetAllStudents()
		{
			return studentRepository.GetAll();
		}

		public virtual List <Group> GetAllGroups()
		{
			return groupRepository.GetAll();
		}

		public virtual List <Subject> GetAllSubjects()
		{
			return subjectRepository.GetAll();
		}

		public virtual List<Subject> GetByTeacherId(int teacherId)
		{
			return subjectRepository.GetByTeacherId(teacherId);
		}
	}
}
