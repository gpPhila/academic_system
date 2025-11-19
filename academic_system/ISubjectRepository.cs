using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface ISubjectRepository : IBaseRepository<Subject>
    {
        Subject GetById(int subjectId);
		List<Subject> GetByTeacherId(int teacherId); //?
		List<Subject> GetByGroupId(); //?
		List<Subject> GetAll(); //all need this?
	}
}
