using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academic_system
{
    public interface IBaseRepository <T>
    {
        void Add(T entity);
        void Update (T entity);
        void Delete (int id);
    }
}
