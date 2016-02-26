using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaWebApi.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        IQueryable<T> List();
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}
