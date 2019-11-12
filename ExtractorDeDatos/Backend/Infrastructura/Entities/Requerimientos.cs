namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requerimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requerimientos()
        {
            PermisosPorRequerimiento = new HashSet<PermisosPorRequerimiento>();
            ProcesosPorRequerimiento = new HashSet<ProcesosPorRequerimiento>();
        }

        [Key]
        [StringLength(50)]
        public string idRequerimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreRequerimiento { get; set; }

        [Required]
        public string RutaRequerimiento { get; set; }

        public int idArea { get; set; }
        public string NombreArea { get; set; }

        public int idTipoRequerimiento { get; set; }

        public string NombreTipoRequerimiento { get; set; }

        public DateTime FechaAsignacion { get; set; }

        public int? idEstadoRequerimiento { get; set; }
        public string NombreEstado { get; set; }

        [Required]
        [StringLength(50)]
        public string Prioridad { get; set; }

        public int? idUsuario { get; set; }

        public int? idLiderProyecto { get; set; }

        public string NombreLider { get; set; }

        public virtual Areas Areas { get; set; }

        public virtual EstadosDeRequerimiento EstadosDeRequerimiento { get; set; }

        public virtual LiderProyecto LiderProyecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermisosPorRequerimiento> PermisosPorRequerimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcesosPorRequerimiento> ProcesosPorRequerimiento { get; set; }

        public virtual TipoRequerimiento TipoRequerimiento { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
