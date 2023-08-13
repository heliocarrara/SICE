namespace SICE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Permissao = new HashSet<Permissao>();
        }

        [Key]
        public long usuarioUID { get; set; }

        [Required]
        [StringLength(50)]
        public string cpf { get; set; }

        [Required]
        public string senha { get; set; }

        public string senhaSecundaria { get; set; }

        [Required]
        public string email { get; set; }

        public bool ativo { get; set; }

        public DateTime dataCriacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permissao> Permissao { get; set; }
    }
}
