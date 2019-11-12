using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Backend.Infrastructura.Entities;

namespace Backend.Infrastructura.Interfaces
{
    public interface IReadDataRepository<T>  where T : class
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        //Injectar en otro servicio
        
    }
}
