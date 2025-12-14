using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
	public class StudentManager : BaseManager
	{
		public StudentManager(
		   IUserRepository userRepository,
		   IStudentRepository studentRepository,
		   ITeacherRepository teacherRepository,
		   IGroupRepository groupRepository,
		   ISubjectRepository subjectRepository,
		   IGOSRepository gOSRepository,
		   IGradeRepository gradeRepository,
		   IGOSSRepository gOSSRepository) : base(userRepository, studentRepository, teacherRepository, groupRepository, subjectRepository, gOSRepository, gradeRepository, gOSSRepository)
		{ }
		public List<Grade> ViewGradesByStudent(int studentId)
		{
			return gradeRepository.GetByStudentId(studentId);
		}
		public override List<Student> GetStudentsByGroup(int groupId)
		{
			throw new UnauthorizedAccessException("Restriction by role 'Student': cannot get students by group.");
		}
		public override List<Student> GetAllStudents() 
		{
			throw new UnauthorizedAccessException("Restriction by role 'Student': cannot get all students.");
		}
		public override List<Group> GetAllGroups()
		{
			throw new UnauthorizedAccessException("Restriction by role 'Student': cannot get all groups.");
		}
		public override List<Subject> GetAllSubjects()
		{
			throw new UnauthorizedAccessException("Restriction by role 'Student': cannot get all subjects.");
		}
		public override List<Subject> GetByTeacherId(int teacherId)
		{
			throw new UnauthorizedAccessException("Restriction by role 'Student': cannot get subjects by teacher id.");
		}
	}
}
