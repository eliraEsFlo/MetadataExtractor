namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermisosDePU")]
    public partial class PermisosDePU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PermisosDePU()
        {
            PermisosPorRequerimiento = new HashSet<PermisosPorRequerimiento>();
        }

        [Key]
        public int idPermisoPU { get; set; }

        [Required]
        [StringLength(50)]
        public string NombrePermiso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermisosPorRequerimiento> PermisosPorRequerimiento { get; set; }
    }
}
