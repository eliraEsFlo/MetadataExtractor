namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermisosPorRequerimiento")]
    public partial class PermisosPorRequerimiento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPermiso_Req { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string idRequerimiento { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idPermisoPU { get; set; }

        public bool EstadoPermiso { get; set; }

        public virtual PermisosDePU PermisosDePU { get; set; }

        public virtual Requerimientos Requerimientos { get; set; }
    }
}
