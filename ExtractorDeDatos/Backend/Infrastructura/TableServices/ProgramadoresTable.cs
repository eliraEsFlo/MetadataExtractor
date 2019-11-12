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
    public class ProgramadoresTable : IRepository<Usuarios>
    {
        Dictionary<string, string> procedimientos = new Dictionary<string, string>();

        public ProgramadoresTable()
        {
            procedimientos.Add("ObtenerUsuarios", "usp_ObtenerProgramadoresConId");
        }
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
            List<Usuarios> usuariosConId = new List<Usuarios>();

            SQLConfiguration sqlInstance = new SQLConfiguration();
            using (SqlCommand command = new SqlCommand(procedimientos["ObtenerUsuarios"], sqlInstance.GetConnection()) )
            {
                sqlInstance.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuariosConId.Add
                    (
                        new Usuarios()
                        {
                            idUsuario = (int)reader["idUsuario"],
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Estado = bool.Parse(reader["Estado"].ToString())
                        }
                    );
                }

                sqlInstance.Dispose();
            }
            return usuariosConId;
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
