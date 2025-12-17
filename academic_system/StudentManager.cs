using System;
using System.Collections.Generic;
using System.Data;
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
		public List<Grade> ViewGradesByStudentAndSubject(int studentId, int subjectId)
		{
			return gradeRepository.GetByStudentAndSubject(studentId, subjectId);
		}
		public DataTable GetSubjectsForStudent(int groupId)
		{
			int gosId = groupRepository.GetGosIdByGroupId(groupId);
			return gOSSRepository.GetByGosIdWithSubjectName(gosId);
		}
	}
}
