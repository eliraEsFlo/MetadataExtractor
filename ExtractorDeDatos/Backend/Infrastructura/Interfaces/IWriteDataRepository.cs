using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Infrastructura.Interfaces
{
    public interface IWriteDataRepository<T> where T : class
    {

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(T entities);
    }
}
