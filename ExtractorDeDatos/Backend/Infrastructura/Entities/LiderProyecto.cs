namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LiderProyecto")]
    public partial class LiderProyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LiderProyecto()
        {
            EquipoDeTrabajo = new HashSet<EquipoDeTrabajo>();
            Requerimientos = new HashSet<Requerimientos>();
        }

        [Key]
        public int idLiderProyecto { get; set; }

        public int? idUsuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipoDeTrabajo> EquipoDeTrabajo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requerimientos> Requerimientos { get; set; }
    }
}
