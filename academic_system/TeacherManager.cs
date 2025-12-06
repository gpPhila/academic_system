using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public class TeacherManager : BaseManager
    {
		public TeacherManager(
		   IUserRepository userRepository,
		   IStudentRepository studentRepository,
		   ITeacherRepository teacherRepository,
		   IGroupRepository groupRepository,
		   ISubjectRepository subjectRepository,
		   IGOSRepository gOSRepository,
		   IGradeRepository gradeRepository) : base(userRepository, studentRepository, teacherRepository, groupRepository, subjectRepository, gOSRepository, gradeRepository)
		{}
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
			gradeRepository.UpdateValue(gradeId, newValue);
		}

		public void DeleteGrade(int gradeId)
		{
			gradeRepository.Delete(gradeId);
		}
		public List<Grade> ViewGradesByTeacher(int teacherId)
		{
			return gradeRepository.GetByTeacherId(teacherId);
		}
	}
}
