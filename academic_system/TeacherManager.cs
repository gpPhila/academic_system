using System;
using System.Collections.Generic;
using System.Data;
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
		   IGradeRepository gradeRepository,
		   IGOSSRepository gOSSRepository) : base(userRepository, studentRepository, teacherRepository, groupRepository, subjectRepository, gOSRepository, gradeRepository, gOSSRepository)
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
		
		public DataTable GetSubjectsByGroupAndTeacher(int groupId, int teacherId)
		{
			return subjectRepository.GetSubjectsByGroupAndTeacher(groupId, teacherId);
		}

		public DataTable GetStudentsByGroupId(int groupId)
		{
			return studentRepository.GetStudentsByGroupId(groupId);
		}

		public DataTable GetGrades(int studentId, int subjectId, int teacherId)
		{
			return gradeRepository.GetGrades(studentId, subjectId, teacherId);
		}

	}
}
