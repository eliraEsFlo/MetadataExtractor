namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncidenciasProduccion")]
    public partial class IncidenciasProduccion
    {
        [Key]
        [StringLength(40)]
        public string idIncidenciaProduccion { get; set; }

        [Required]
        [StringLength(60)]
        public string NombreIncidencia { get; set; }

        [Required]
        [StringLength(200)]
        public string DescripcionIncidencia { get; set; }

        public DateTime FechaDeEmision { get; set; }

        public int idUsuario { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
