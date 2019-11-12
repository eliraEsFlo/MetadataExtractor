namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipoDeTrabajo")]
    public partial class EquipoDeTrabajo
    {
        [Key]
        public int idEquipo_Trabajo { get; set; }

        public int idLiderProyecto { get; set; }

        public int idUsuario { get; set; }

        public virtual LiderProyecto LiderProyecto { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
