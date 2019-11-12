namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Procesos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Procesos()
        {
            ProcesosPorRequerimiento = new HashSet<ProcesosPorRequerimiento>();
        }

        [Key]
        public int idProceso { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreProceso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcesosPorRequerimiento> ProcesosPorRequerimiento { get; set; }
    }
}
