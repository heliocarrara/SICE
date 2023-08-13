namespace SICE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permissao")]
    public partial class Permissao
    {
        [Key]
        public long permissaoUID { get; set; }

        public bool ativo { get; set; }

        public DateTime dataCriacao { get; set; }

        public int tipoPermissao { get; set; }

        public long chaveAtivacaoUID { get; set; }

        public long usuarioUID { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
