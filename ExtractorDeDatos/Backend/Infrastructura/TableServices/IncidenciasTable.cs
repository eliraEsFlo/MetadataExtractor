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
    public class IncidenciasTable : IRepository<IncidenciasProduccion>
    {
        public void Add(IncidenciasProduccion entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<IncidenciasProduccion> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncidenciasProduccion> Find(Expression<Func<IncidenciasProduccion, bool>> predicate)
        {
            throw new NotImplementedException();
        }


        private Dictionary<string, string> procedimientos = new Dictionary<string, string>();

        public IncidenciasTable()
        {
            procedimientos.Add("ObtenerIncidencias", "usp_ObtenerIncidencias");
        }
        public IEnumerable<IncidenciasProduccion> GetAll()
        {
            List<IncidenciasProduccion> incidencias = new List<IncidenciasProduccion>();

            SQLConfiguration sqlInstance = new SQLConfiguration();
            using (SqlCommand command = new SqlCommand(procedimientos["ObtenerIncidencias"], sqlInstance.GetConnection()))
            {
                sqlInstance.OpenConnection();
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    incidencias.Add
                    (
                        new IncidenciasProduccion()
                        {
                            NombreIncidencia = reader["NombreIncidencia"].ToString(),
                             idIncidenciaProduccion = reader["idIncidenciaProduccion"].ToString(),
                            DescripcionIncidencia = reader["DescripcionIncidencia"].ToString(),
                            FechaDeEmision = Convert.ToDateTime(reader["FechaDeEmision"].ToString())
                        }
                    );
                }

                sqlInstance.Dispose();
                return incidencias;
            }
        }

        public IncidenciasProduccion GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(IncidenciasProduccion entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IncidenciasProduccion entities)
        {
            throw new NotImplementedException();
        }
    }
}
