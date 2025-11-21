using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface IStudentRepository : IBaseRepository <Student>
    {
        Student GetById(int studentId);
        Student GetByUserId(int userId);
		List<Student> GetByGroupId(int groupId); //return multiple rows
    }
}
