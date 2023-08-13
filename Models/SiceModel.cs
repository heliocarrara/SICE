using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SICE.Models
{
    public partial class SiceModel : DbContext
    {
        public SiceModel()
            : base("name=SiceModel")
        {
        }

        public virtual DbSet<Permissao> Permissao { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Permissao)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
