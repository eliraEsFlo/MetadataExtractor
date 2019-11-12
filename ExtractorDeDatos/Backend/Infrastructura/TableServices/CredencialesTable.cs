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
    public class CredencialesTable : IRepository<Credenciales>
    {
        public void Add(Credenciales entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Credenciales> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Credenciales> Find(Expression<Func<Credenciales, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Credenciales> GetAll()
        {
            throw new NotImplementedException();
        }

        public Credenciales GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Credenciales entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(Credenciales entities)
        {
            throw new NotImplementedException();
        }
    }
}
