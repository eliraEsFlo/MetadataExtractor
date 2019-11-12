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
    public class UsuariosSistemaTable : IRepository<Usuarios>
    {
        public void Add(Usuarios entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Usuarios> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuarios> Find(Expression<Func<Usuarios, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuarios> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuarios GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Usuarios entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(Usuarios entities)
        {
            throw new NotImplementedException();
        }
    }
}
