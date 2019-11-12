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
    public class CredencialesUsuarioTable : IRepository<CredencialesUsuario>
    {
        public void Add(CredencialesUsuario entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<CredencialesUsuario> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CredencialesUsuario> Find(Expression<Func<CredencialesUsuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CredencialesUsuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public CredencialesUsuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(CredencialesUsuario entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(CredencialesUsuario entities)
        {
            throw new NotImplementedException();
        }
    }
}
