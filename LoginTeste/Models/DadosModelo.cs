namespace LoginTeste.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DadosModelo : DbContext
    {
        public DadosModelo()
            : base("name=DadosModelo")
        {
        }

        public virtual DbSet<navio> navio { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<navio>()
                .Property(e => e.vesselName)
                .IsUnicode(false);

            modelBuilder.Entity<navio>()
                .Property(e => e.flag)
                .IsUnicode(false);

            modelBuilder.Entity<navio>()
                .Property(e => e.callSign)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.senha)
                .IsUnicode(false);
        }
    }
}
