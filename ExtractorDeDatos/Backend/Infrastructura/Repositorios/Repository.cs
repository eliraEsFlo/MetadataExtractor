using Backend.Infrastructura.ContextoDatos;
using Backend.Infrastructura.Entities;
using Backend.Infrastructura.Interfaces;
using System;
using System.Collections.Generic;

namespace Backend.Infrastructura.Repositorios
{
    public class Repository<T> : IRepository<T> where T: class
    {
        
        IRepository<T> dbset;

        public Repository(IRepository<T> tableService)
        {
            dbset = tableService;
        }


        public IEnumerable<T> GetAll()
        {
            return dbset.GetAll();
        }


        public T GetById(int id)
        {
            return dbset.GetById(id);
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return dbset.Find(predicate);
        }

        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            dbset.AddRange(entities);
        }

        public void Remove(T entity)
        {
            dbset.Remove(entity);
        }

        public void RemoveRange(T entities)
        {
            dbset.Remove(entities);
        }
    }
}
