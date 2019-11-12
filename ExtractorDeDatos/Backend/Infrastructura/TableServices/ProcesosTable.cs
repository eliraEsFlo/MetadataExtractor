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
    public class ProcesosTable : IRepository<Procesos>
    {
        public void Add(Procesos entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Procesos> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Procesos> Find(Expression<Func<Procesos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Procesos> GetAll()
        {
            throw new NotImplementedException();
        }

        public Procesos GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Procesos entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(Procesos entities)
        {
            throw new NotImplementedException();
        }
    }
}
