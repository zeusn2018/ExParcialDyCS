using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zsunapi.Common.Domain.Repository
{
    public interface IRepository<T> where T:class
    {
        IReadOnlyList<T> GetAll();

        T Get(long id);
        void Create(T entity);

        void Delete(T entity);
    }
}
