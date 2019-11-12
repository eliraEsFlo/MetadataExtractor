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
    public class EstadosDeRequerimientoTable : IRepository<EstadosDeRequerimiento>
    {
        public void Add(EstadosDeRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<EstadosDeRequerimiento> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstadosDeRequerimiento> Find(Expression<Func<EstadosDeRequerimiento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstadosDeRequerimiento> GetAll()
        {
            throw new NotImplementedException();
        }

        public EstadosDeRequerimiento GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(EstadosDeRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(EstadosDeRequerimiento entities)
        {
            throw new NotImplementedException();
        }
    }
}
