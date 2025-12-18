using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
	/// <summary>
	/// Studento valdymo logika.
	/// </summary>
	public class StudentManager : BaseManager
	{
		/// <summary>
		/// Sukuria StudentManager objektą.
		/// </summary>
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
		/// <summary>
		/// Gauna studento pažymius pagal dalyką.
		/// </summary>
		public List<Grade> ViewGradesByStudentAndSubject(int studentId, int subjectId)
		{
			return gradeRepository.GetByStudentAndSubject(studentId, subjectId);
		}
		/// <summary>
		/// Gauna studento dalykus pagal studento grupės ID.
		/// </summary>
		public DataTable GetSubjectsForStudent(int groupId)
		{
			int gosId = groupRepository.GetGosIdByGroupId(groupId);
			return gOSSRepository.GetByGosIdWithSubjectName(gosId);
		}
	}
}
