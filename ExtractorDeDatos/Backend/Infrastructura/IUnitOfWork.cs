using Backend.Infrastructura.DomainDataContract;
using Backend.Infrastructura.Entities;
using Backend.Infrastructura.Interfaces;

namespace Backend.Infrastructura
{
    public interface IUnitOfWork
    {

         IRequerimientosRepository Requerimientos { get; }

        IRepository<Areas> Areas { get; }
        IRepository<Credenciales> Credenciales { get; }

        IRepository<CredencialesUsuario> CredencialesUsuario { get; }

        IRepository<EquipoDeTrabajo> EquiposDeTrabajo { get; }

        IRepository<EstadosDeRequerimiento> EstadosRequerimientos { get; }

        IRepository<Usuarios> Programadores { get; }
        IRepository<IncidenciasProduccion> Incidencias { get; }

        IRepository<LiderProyecto> LideresProyecto { get; }

        IRepository<PermisosDePU> PermisosDePU { get; }

        IRepository<PermisosPorRequerimiento> PermisosPorRequerimiento { get; }

        IRepository<Procesos> Procesos { get; }

        IRepository<ProcesosPorRequerimiento> ProcesosPorRequerimiento { get; }

        IRepository<TipoRequerimiento> TiposRequerimiento { get; }


    }
}
