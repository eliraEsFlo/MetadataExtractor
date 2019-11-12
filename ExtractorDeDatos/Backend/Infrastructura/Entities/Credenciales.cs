namespace Backend.Infrastructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Credenciales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Credenciales()
        {
            CredencialesUsuario = new HashSet<CredencialesUsuario>();
        }

        [Key]
        public int idCredencial { get; set; }

        [Required]
        [StringLength(50)]
        public string DescripcionCredencial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CredencialesUsuario> CredencialesUsuario { get; set; }
    }
}
