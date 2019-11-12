using Backend.Infrastructura.Entities;
using Backend.Infrastructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructura.TableServices
{
    public class TipoRequerimientoTable : IRepository<TipoRequerimiento>
    {
        public void Add(TipoRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TipoRequerimiento> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoRequerimiento> Find(Expression<Func<TipoRequerimiento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoRequerimiento> GetAll()
        {
            throw new NotImplementedException();
        }

        public TipoRequerimiento GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TipoRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(TipoRequerimiento entities)
        {
            throw new NotImplementedException();
        }
    }
}
