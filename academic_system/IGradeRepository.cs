using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface IGradeRepository : IBaseRepository<Grade>
    {
        Grade GetById(int gradeId);
        List <Grade> GetByStudentId(int studentId);
        List<Grade> GetByTeacherId(int subjectId);
        void UpdateValue(int gradeId, string newValue);
        DataTable GetGrades(int studentId, int subjectId, int teacherId);

	}
}
