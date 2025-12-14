using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface IGOSSRepository : IBaseRepository<GOS_Subject>
    {
		GOS_Subject GetById(int gossId);
		List<GOS_Subject> GetAll();
		List <GOS_Subject> GetByGosId(int gosId);
		DataTable GetByGosIdWithSubjectName(int gosId);
	}
}
