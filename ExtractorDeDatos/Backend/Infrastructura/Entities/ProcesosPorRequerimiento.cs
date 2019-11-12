namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcesosPorRequerimiento")]
    public partial class ProcesosPorRequerimiento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProcesos_Req { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string idRequerimiento { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProceso { get; set; }

        public bool EstadoProceso { get; set; }

        public virtual Procesos Procesos { get; set; }

        public virtual Requerimientos Requerimientos { get; set; }
    }
}
