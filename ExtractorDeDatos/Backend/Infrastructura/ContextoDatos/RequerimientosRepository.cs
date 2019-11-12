using Backend.Infrastructura.DomainDataContract;
using Backend.Infrastructura.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Backend.Infrastructura.ContextoDatos
{
    public class RequerimientosRepository : IRequerimientosRepository
    {
        public RequerimientosRepository()
        {
        }

        public string ObtenerUltimoRequerimiento()
        {
            string idRequerimiento = "";
            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerUltimoIdDeRequerimiento", instance.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idRequerimiento = reader["idRequerimiento"].ToString();
                }
                command.Dispose();
            }
            return idRequerimiento;
        }


        public IEnumerable<Requerimiento> ObtenerRequerimientoPorTipoAsignacion(string tipoProyecto)
        {
            List<Requerimiento> requerimientos = new List<Requerimiento>();
            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerRequerimientosPorAsignacion",
                    instance.GetConnection());
                command.CommandType = CommandType.StoredProcedure;



                command.Parameters.Add("@tipoDeProyecto", SqlDbType.VarChar, 40).Value = tipoProyecto;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    requerimientos.Add(new Requerimiento()
                    {
                        idRequerimiento = reader["idRequerimiento"].ToString(),
                        NombreRequerimiento = reader["NombreRequerimiento"].ToString(),
                        NombreArea = reader["NombreArea"].ToString(),
                        RutaRequerimiento = reader["RutaRequerimiento"].ToString(),
                        NombreTipoRequerimiento = reader["NombreTipoRequerimiento"].ToString(),
                        FechaAsignacion = Convert.ToDateTime(reader["FechaAsignacion"].ToString()),
                        NombreEstado = reader["NombreEstado"].ToString(),
                        NombreLider = reader["Programador"].ToString(),
                        Prioridad = reader["Prioridad"].ToString()

                    });
                }

                instance.Dispose();
                command.Dispose();
            }

            return requerimientos;
        }




        public List<TipoRequerimiento> ObtenerTiposRequerimientos()
        {
            List<TipoRequerimiento> tipoRequerimientos = new List<TipoRequerimiento>();
            SQLConfiguration instance = new SQLConfiguration();
            instance.OpenConnection();
            using (SqlCommand command = new SqlCommand("usp_ObtenerTiposRequerimiento",
                    instance.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tipoRequerimientos.Add
                    (
                        new TipoRequerimiento()
                        {
                            idTipoRequerimiento = (int)reader["idTipoRequerimiento"],
                            NombreTipoRequerimiento = reader["NombreTipoRequerimiento"].ToString()
                        }
                    );
                }
            }
            instance.Dispose();
            return tipoRequerimientos;
        }

        public List<Procesos> ObtenerProcesos()
        {

            List<Procesos> procesosPorRequerimiento = new List<Procesos>();
            SQLConfiguration instance = new SQLConfiguration();
            instance.OpenConnection();
            using (SqlCommand command = new SqlCommand("usp_ObtenerProcesos",
                    instance.GetConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    procesosPorRequerimiento.Add
                    (
                        new Procesos()
                        {
                            idProceso = (int)reader["idProceso"],
                            NombreProceso = reader["NombreProceso"].ToString()
                        }
                    );
                }
                instance.Dispose();
            }
            return procesosPorRequerimiento;
        }

        public List<PermisosDePU> ObtenerPermisosDePU()
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

        public List<Usuarios> ObtenerProgramadoresConId()
        {

            List<Usuarios> usuariosConId = new List<Usuarios>();

            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerProgramadoresConId",
                    instance.GetConnection());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuariosConId.Add
                    (
                        new Usuarios()
                        {
                            idUsuario = (int)reader["idUsuario"],
                            NombreUsuario = reader["NombreUsuario"].ToString()
                        }
                    );
                }

                command.Dispose();
            }
            return usuariosConId;

        }

        public List<Areas> ObtenerAreas()
        {
            List<Areas> areas = new List<Areas>();
            SQLConfiguration instance = new SQLConfiguration();
            instance.OpenConnection();
            using (SqlCommand command = new SqlCommand("usp_ObtenerAreas", instance.GetConnection()))
            {
                ;

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    areas.Add
                    (
                        new Areas()
                        {
                            idArea = (int)reader["IdArea"],
                            NombreArea = reader["NombreArea"].ToString()
                        }
                    );
                }
                instance.Dispose();
            }
            return areas;
        }

        public string ObtenerUltimoIdDeRequerimiento()
        {
            string idRequerimiento = "";
            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerUltimoIdDeRequerimiento",
                    instance.GetConnection());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idRequerimiento = reader["idRequerimiento"].ToString();
                }
                command.Dispose();
            }
            return idRequerimiento;
        }

        public string ObtenerUltimoIdDeIndidencia()
        {
            string idIncidencia = "";
            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerUltimoIdDeIncidencia",
                    instance.GetConnection());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idIncidencia = reader["idIncidenciaProduccion"].ToString();
                }
                command.Dispose();
            }
            return idIncidencia;
        }

        public bool InsertarRequerimiento(Requerimientos requerimiento)
        {

            using (SQLConfiguration instance = new SQLConfiguration())
            {

                instance.OpenConnection();

                SqlCommand insertLiderCommand = new SqlCommand("usp_InsertarLiderProyecto", instance.GetConnection());
                insertLiderCommand.CommandType = CommandType.StoredProcedure;
                insertLiderCommand.Parameters.Add("@idUsuario", SqlDbType.Int).Value = requerimiento.idLiderProyecto;

                bool thisQuery = insertLiderCommand.ExecuteNonQuery() == 1 ? true : false;
                insertLiderCommand.Dispose();

                SqlCommand insertRequerimientoCommand = new SqlCommand("usp_InsertarRequerimiento", instance.GetConnection());
                insertRequerimientoCommand.CommandType = CommandType.StoredProcedure;

                insertRequerimientoCommand.Parameters.Add("@idRequerimiento", SqlDbType.VarChar, 50).Value = requerimiento.idRequerimiento;
                insertRequerimientoCommand.Parameters.Add("@nombreRequerimiento", SqlDbType.VarChar, 50).Value = requerimiento.NombreRequerimiento;

                insertRequerimientoCommand.Parameters.Add("@rutaRequerimiento", SqlDbType.VarChar, -1).Value = requerimiento.RutaRequerimiento;

                insertRequerimientoCommand.Parameters.Add("@idArea", SqlDbType.Int).Value = requerimiento.idArea;

                insertRequerimientoCommand.Parameters.Add("@idTipoRequerimiento", SqlDbType.Int).Value = requerimiento.idTipoRequerimiento;

                insertRequerimientoCommand.Parameters.Add("@idEstadoRequerimiento", SqlDbType.Int).Value = requerimiento.idEstadoRequerimiento;

                insertRequerimientoCommand.Parameters.Add("@prioridad", SqlDbType.VarChar, 50).Value = "Alta";

                insertRequerimientoCommand.Parameters.AddWithValue("@idUsuario", DBNull.Value).Value = requerimiento.idUsuario == 0 ?
                                                                        DBNull.Value : (object)requerimiento.idUsuario;

                insertRequerimientoCommand.Parameters.AddWithValue("@idLiderProyecto", DBNull.Value).Value = requerimiento.idLiderProyecto == 0 ?
                                                                        DBNull.Value : (object)requerimiento.idLiderProyecto;

                bool queryIsOk = insertRequerimientoCommand.ExecuteNonQuery() == 1 ? true : false;

                if (thisQuery)
                {
                    insertRequerimientoCommand.Dispose();

                    foreach (var permiso in requerimiento.PermisosPorRequerimiento)
                    {
                        using (SqlCommand insertPermisosCommand = new SqlCommand("GuardarPermisosPorRequerimiento", instance.GetConnection()))
                        {
                            insertPermisosCommand.CommandType = CommandType.StoredProcedure;

                            insertPermisosCommand.Parameters.Add("@idRequerimiento", SqlDbType.VarChar, 40).Value = requerimiento.idRequerimiento;
                            insertPermisosCommand.Parameters.Add("@idPermisoPU", SqlDbType.Int).Value = permiso.idPermisoPU;
                            insertPermisosCommand.Parameters.Add("@estado", SqlDbType.Bit).Value = permiso.EstadoPermiso;
                            insertPermisosCommand.ExecuteNonQuery();

                        }

                    }
                    instance.Dispose();
                    return true;
                }

                return false;

            }


        }

        public bool InsertarIncidencia(IncidenciasProduccion incidencia)
        {


            using (SQLConfiguration config = new SQLConfiguration())
            {
                config.OpenConnection();

                SqlCommand command = new SqlCommand("usp_InsertarIncidencia",
                    config.GetConnection());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@idIncidenciaProduccion", SqlDbType.VarChar, 40).Value = incidencia.idIncidenciaProduccion;
                command.Parameters.Add("@nombreIncidencia", SqlDbType.VarChar, 60).Value = incidencia.NombreIncidencia;

                command.Parameters.Add("@DescripcionIncidencia", SqlDbType.VarChar, 200).Value = incidencia.DescripcionIncidencia;

                command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = incidencia.idUsuario;

                bool queryIsOk = command.ExecuteNonQuery() == 1 ? true : false;

                config.Dispose();
                command.Dispose();
                return queryIsOk;
            }


        }

        public bool InsertarEquiposDeTrabajo(int idLider, List<Usuarios> programadores)
        {
            using (SQLConfiguration config = new SQLConfiguration())
            {
                config.OpenConnection();

                bool isQueryOk = false;
                foreach (var permiso in programadores)
                {
                    using (SqlCommand command = new SqlCommand("usp_InsertarEquiposDeTrabajo",
                    config.GetConnection()))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@idLiderProyecto", SqlDbType.Int).Value = idLider;
                        command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = permiso.idUsuario;

                        isQueryOk = command.ExecuteNonQuery() == 1 ? true : false;

                    }

                }

                return isQueryOk;

            }


        }

        public List<EstadosDeRequerimiento> ObtenerEstadoRequerimiento()
        {
            List<EstadosDeRequerimiento> estados = new List<EstadosDeRequerimiento>();
            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerEstadosDeRequerimiento", instance.GetConnection());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    estados.Add(new EstadosDeRequerimiento()
                    {
                        idEstadoRequerimiento = Int32.Parse(reader["idEstadoRequerimiento"].ToString()),
                        NombreEstado = reader["NombreEstado"].ToString()
                    });
                }
                command.Dispose();
                instance.Dispose();
            }
            return estados;
        }


        public List<ProyectosPorProgramador> ObtenerProyectosPorIdProgramador(int id)
        {
            List<ProyectosPorProgramador> proyectos = new List<ProyectosPorProgramador>();
            using (SQLConfiguration config = new SQLConfiguration())
            {
                config.OpenConnection();

                using (SqlCommand command = new SqlCommand("usp_ObtenerProyectosPorIdProgramador", config.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = id;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        proyectos.Add
                           (
                               new ProyectosPorProgramador()
                               {
                                   NombreRequerimiento = reader["NombreRequerimiento"].ToString(),
                                   idRequerimiento = reader["idRequerimiento"].ToString(),
                                   FechaAsignacion = Convert.ToDateTime(reader["FechaAsignacion"].ToString()),
                                   Estado = reader["Estado"].ToString()
                               }
                           );
                    }

                    command.Dispose();
                }

            }

            return proyectos;

        }

        public List<Requerimientos> GetAll()
        {
            List<Requerimientos> requerimientos = new List<Requerimientos>();
            using (SQLConfiguration instance = new SQLConfiguration())
            {
                instance.OpenConnection();

                SqlCommand command = new SqlCommand("usp_ObtenerRequerimientos", instance.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    requerimientos.Add(new Requerimientos()
                    {
                        idRequerimiento = reader["idRequerimiento"].ToString(),
                        NombreRequerimiento = reader["NombreRequerimiento"].ToString(),
                        RutaRequerimiento = reader["RutaRequerimiento"].ToString(),
                        idArea = Int32.Parse(reader["idArea"].ToString()),
                        idTipoRequerimiento = Int32.Parse(reader["idTipoRequerimiento"].ToString()),
                        FechaAsignacion = Convert.ToDateTime(reader["FechaAsignacion"].ToString()),
                        idEstadoRequerimiento = Int32.Parse(reader["idEstadoRequerimiento"].ToString()),
                        Prioridad = reader["Prioridad"].ToString(),
                        idUsuario = Int32.Parse(reader["idUsuario"].ToString()),
                        idLiderProyecto = Int32.Parse(reader["idLiderProyecto"].ToString())
                    });
                }

                instance.Dispose();
                command.Dispose();
            }

            return requerimientos;
        }

        public List<Usuarios> ObtenerProgramdoresEnRequerimiento(string idRequerimiento)
        {
            List<Usuarios> proyectos = new List<Usuarios>();
            using (SQLConfiguration config = new SQLConfiguration())
            {
                config.OpenConnection();

                using (SqlCommand command = new SqlCommand("usp_ObtenerProgramadoresEnRequerimiento", config.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@idRequerimiento", SqlDbType.VarChar, 50).Value = idRequerimiento;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        proyectos.Add
                           (
                               new Usuarios()
                               {
                                   idUsuario = Int32.Parse(reader["idUsuario"].ToString()),
                                   NombreUsuario = reader["Programador"].ToString()
                               }
                           );
                    }

                    command.Dispose();
                }

            }

            return proyectos;
        }

        public List<PermisosDePU> ObtenerPermisosPuRequeridos(string idRequerimiento)
        {
            List<PermisosDePU> proyectos = new List<PermisosDePU>();
            using (SQLConfiguration config = new SQLConfiguration())
            {
                config.OpenConnection();

                using (SqlCommand command = new SqlCommand("usp_ObtenerPermisosPuRequeridos", config.GetConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@idRequerimiento", SqlDbType.VarChar, 50).Value = idRequerimiento;

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        proyectos.Add
                           (
                               new PermisosDePU()
                               {
                                   idPermisoPU = Int32.Parse(reader["idPermisoPU"].ToString()),
                                   NombrePermiso = reader["NombrePermiso"].ToString()
                               }
                           );
                    }

                    command.Dispose();
                }

            }

            return proyectos;
        }
    }
}
