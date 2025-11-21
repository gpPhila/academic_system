using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface IGOSRepository : IBaseRepository<GroupOfSubjects>
    {
        GroupOfSubjects GetById(int gosId);
        GroupOfSubjects GetByGroupId(int groupId);
    }
}
