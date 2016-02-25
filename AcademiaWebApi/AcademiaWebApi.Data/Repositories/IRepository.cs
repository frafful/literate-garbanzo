using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.Data.Repositories
{
    public interface IRepository<T>
    {
        void Insert(T entity);
    }
}
