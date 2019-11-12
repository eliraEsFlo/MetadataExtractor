namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CredencialesUsuario")]
    public partial class CredencialesUsuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCredencial_Usuario { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCredencial { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUsuario { get; set; }

        public virtual Credenciales Credenciales { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
