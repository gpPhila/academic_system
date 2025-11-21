using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        Group GetById(int groupId);
    }
}
