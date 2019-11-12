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
    public class ProcesosPorRequerimientoTable : IRepository<ProcesosPorRequerimiento>
    {
        public void Add(ProcesosPorRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ProcesosPorRequerimiento> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProcesosPorRequerimiento> Find(Expression<Func<ProcesosPorRequerimiento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProcesosPorRequerimiento> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProcesosPorRequerimiento GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProcesosPorRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(ProcesosPorRequerimiento entities)
        {
            throw new NotImplementedException();
        }
    }
}
