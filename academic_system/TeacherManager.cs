using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
	/// <summary>
	/// Dėstytojo valdymo logika.
	/// </summary>
	public class TeacherManager : BaseManager
    {
		/// <summary>
		/// Sukuria TeacherManager objektą.
		/// </summary>
		public TeacherManager(
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
		/// Sukuria pažymį.
		/// </summary>
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
		/// <summary>
		/// Redaguoja pažymį.
		/// </summary>
		public void EditGrade(int gradeId, string newValue)
		{
			gradeRepository.UpdateValue(gradeId, newValue);
		}
		/// <summary>
		/// Ištrina pažymį.
		/// </summary>
		public void DeleteGrade(int gradeId)
		{
			gradeRepository.Delete(gradeId);
		}
		/// <summary>
		/// Gauna dalykus pagal studentų grupę ir dėstytoją.
		/// </summary>
		public DataTable GetSubjectsByGroupAndTeacher(int groupId, int teacherId)
		{
			return subjectRepository.GetSubjectsByGroupAndTeacher(groupId, teacherId);
		}
		/// <summary>
		/// Gauna studento pažymius pagal dalyką ir dėstytoją.
		/// </summary>
		public DataTable GetGrades(int studentId, int subjectId, int teacherId)
		{
			return gradeRepository.GetGrades(studentId, subjectId, teacherId);
		}

	}
}
