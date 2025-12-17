using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        Teacher GetById(int teacherId);
		Teacher GetByUserId(int userId);
        List<Teacher> GetAll();
    }
}
