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
    public class AreasTable : IRepository<Areas>
    {
        public void Add(Areas entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Areas> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Areas> Find(Expression<Func<Areas, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Areas> GetAll()
        {
            throw new NotImplementedException();
        }

        public Areas GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Areas entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(Areas entities)
        {
            throw new NotImplementedException();
        }
    }
}
