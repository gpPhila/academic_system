using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface ISubjectRepository : IBaseRepository<Subject>
    {
        Subject GetById(int subjectId);
		List<Subject> GetAll();
		List<Subject> GetByTeacherId(int teacherId);
		void AssignTeacherToSubject(int subjectId, int teacherId);
		DataTable GetSubjectsByGroupAndTeacher(int groupId, int teacherId);
	}
}
