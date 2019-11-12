namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadosDeRequerimiento")]
    public partial class EstadosDeRequerimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadosDeRequerimiento()
        {
            Requerimientos = new HashSet<Requerimientos>();
        }

        [Key]
        public int idEstadoRequerimiento { get; set; }

        [Required]
        [StringLength(40)]
        public string NombreEstado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requerimientos> Requerimientos { get; set; }
    }
}
