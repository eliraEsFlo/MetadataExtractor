using Backend.Infrastructura.Entities;
using System.Collections.Generic;

namespace Backend.Infrastructura.DomainDataContract
{
    public interface IRequerimientosRepository
    {
        IEnumerable<Requerimiento> ObtenerRequerimientoPorTipoAsignacion(string tipoProyecto);
        List<Areas> ObtenerAreas();
        string ObtenerUltimoRequerimiento();

        List<TipoRequerimiento> ObtenerTiposRequerimientos();

        List<Procesos> ObtenerProcesos();

        List<PermisosDePU> ObtenerPermisosDePU();

        List<Usuarios> ObtenerProgramadoresConId();

        string ObtenerUltimoIdDeRequerimiento();
        string ObtenerUltimoIdDeIndidencia();

        bool InsertarRequerimiento(Requerimientos requerimiento);
        bool InsertarIncidencia(IncidenciasProduccion incidencia);

         bool InsertarEquiposDeTrabajo(int lider, List<Usuarios> programadores);

        List<EstadosDeRequerimiento> ObtenerEstadoRequerimiento();
        List<ProyectosPorProgramador> ObtenerProyectosPorIdProgramador(int id);

        List<Requerimientos> GetAll();

        List<Usuarios> ObtenerProgramdoresEnRequerimiento(string idRequerimiento);

        List<PermisosDePU> ObtenerPermisosPuRequeridos(string idRequerimiento);

    }
}
