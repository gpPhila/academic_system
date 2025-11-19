using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
	public interface IUserRepository : IBaseRepository<User>
	{
		User GetByLogin(string login);  
		//void Add(User user);            
		//void Update(User user);         
		//void Delete(int userId);
	}
}

