using Backend.Infrastructura.Entities;
using Backend.Infrastructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructura.TableServices
{
    public class LiderProyectoTable : IRepository<LiderProyecto>
    {
        public void Add(LiderProyecto entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<LiderProyecto> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LiderProyecto> Find(Expression<Func<LiderProyecto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LiderProyecto> GetAll()
        {
            List<LiderProyecto> lideres = new List<LiderProyecto>();
            
            using (SqlCommand command = new SqlCommand("usp_ObtenerLiderProyecto", new SQLConfiguration().GetConnection()))
            {

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lideres.Add(new LiderProyecto()
                    {
                        idLiderProyecto = Int32.Parse(reader["idLiderProyecto"].ToString()),
                        idUsuario = Int32.Parse(reader["idUsuario"].ToString()),
                    });
                }

                command.Dispose();
            }

            return lideres;
        }

        public LiderProyecto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(LiderProyecto entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(LiderProyecto entities)
        {
            throw new NotImplementedException();
        }
    }
}
