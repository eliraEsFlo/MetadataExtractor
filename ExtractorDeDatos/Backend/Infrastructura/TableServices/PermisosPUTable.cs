using Backend.Infrastructura.Entities;
using Backend.Infrastructura.Interfaces;
using Backend.Infrastructura.TableServices.DataArtifacts;
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
    public class PermisosPUTable : IRepository<PermisosDePU>, IStoredProceduresConfigurator
    {
        
        public PermisosPUTable()
        {
            
        }

        public Dictionary<string, string> procedimientoAlmacenados { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(PermisosDePU entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<PermisosDePU> entities)
        {
            throw new NotImplementedException();
        }


        public string GetProcedure(string alias)
        {
            throw new NotImplementedException();
        }


        public void AddStoreProcedure(string alias, string storedProcedure)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermisosDePU> Find(Expression<Func<PermisosDePU, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermisosDePU> GetAll()
        {
            List<PermisosDePU> permisosDePU = new List<PermisosDePU>();

            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerPermisosDePU",
                    instance.GetConnection());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    permisosDePU.Add
                    (
                        new PermisosDePU()
                        {
                            idPermisoPU = (int)reader["idPermisoPU"],
                            NombrePermiso = reader["NombrePermiso"].ToString()
                        }
                    );
                }

                command.Dispose();
            }
            return permisosDePU;
        }

        public PermisosDePU GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PermisosDePU entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(PermisosDePU entities)
        {
            throw new NotImplementedException();
        }
    }
}
