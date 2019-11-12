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
    public class PermisosPorRequerimientoTable : IRepository<PermisosPorRequerimiento>
    {
        private IStoredProceduresConfigurator storeProcConfig;
        public PermisosPorRequerimientoTable()
        {
            storeProcConfig = new StoredProceduresConfigurator();
            SetStoredProcedures();
        }

        public void SetStoredProcedures()
        {
            storeProcConfig.AddStoreProcedure("ObtenerPermisoPorRequerimiento", "usp_ObtenerPermisosPorRequerimiento");
        }

        public void Add(PermisosPorRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<PermisosPorRequerimiento> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermisosPorRequerimiento> Find(Expression<Func<PermisosPorRequerimiento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PermisosPorRequerimiento> GetAll()
        {
            List<PermisosPorRequerimiento> permisosDePU = new List<PermisosPorRequerimiento>();

            SQLConfiguration instance = new SQLConfiguration();

            string procedimiento = storeProcConfig.GetProcedure("ObtenerPermisoPorRequerimiento");

            using ( SqlCommand command = new SqlCommand(procedimiento, instance.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    permisosDePU.Add
                    (
                        new PermisosPorRequerimiento()
                        {
                            idPermiso_Req = (int)reader["idPermiso_Req"],
                            idRequerimiento = reader["idRequerimiento"].ToString(),
                            idPermisoPU = Int32.Parse(reader["idPermisoPU"].ToString()),
                            EstadoPermiso = bool.Parse(reader["EstadoProceso"].ToString())
                        }
                    );
                }

                command.Dispose();
            }
            return permisosDePU;
        }

        public PermisosPorRequerimiento GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PermisosPorRequerimiento entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(PermisosPorRequerimiento entities)
        {
            throw new NotImplementedException();
        }
    }
}
