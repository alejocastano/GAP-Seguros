using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GAP.Seguros.Data.Models
{
    public partial class SegurosDbContext : DbContext
    {
        public SegurosDbContext(DbContextOptions<SegurosDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ClientePoliza> ClientePoliza { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
        public virtual DbSet<TipoCubrimiento> TipoCubrimiento { get; set; }
        public virtual DbSet<TipoRiesgo> TipoRiesgo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Identificacion)
                    .HasColumnName("identificacion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientePoliza>(entity =>
            {
                entity.HasKey(e => e.IdClientePoliza);

                entity.Property(e => e.IdClientePoliza).HasColumnName("idClientePoliza");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ClientePoliza)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_ClientePoliza_Cliente");

                entity.HasOne(d => d.IdPolizaNavigation)
                    .WithMany(p => p.ClientePoliza)
                    .HasForeignKey(d => d.IdPoliza)
                    .HasConstraintName("FK_ClientePoliza_Poliza");
            });

            modelBuilder.Entity<Poliza>(entity =>
            {
                entity.HasKey(e => e.IdPoliza);

                entity.Property(e => e.IdPoliza).HasColumnName("idPoliza");

                entity.Property(e => e.IdTipoRiesgo).HasColumnName("idTipoRiesgo");

                entity.Property(e => e.InicioVigencia)
                    .HasColumnName("inicioVigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoCobertura).HasColumnName("periodoCobertura");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("money");

                
                entity.Property(e => e.Cobertura)
                    .HasColumnName("cobertura")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdTipoRiesgoNavigation)
                    .WithMany(p => p.Poliza)
                    .HasForeignKey(d => d.IdTipoRiesgo)
                    .HasConstraintName("FK_Poliza_TipoRiesgo");

                entity.HasOne(d => d.IdTipoCubrimientoNavigation)
                    .WithMany(p => p.Poliza)
                    .HasForeignKey(d => d.IdTipoCubrimiento)
                    .HasConstraintName("FK_Poliza_TipoCubrimiento");
            });

            modelBuilder.Entity<TipoCubrimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoCubrimiento);

                entity.Property(e => e.IdTipoCubrimiento)
                    .HasColumnName("idTipoCubrimiento")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DescCubrimiento)
                    .IsRequired()
                    .HasColumnName("tipoCubrimiento")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoRiesgo>(entity =>
            {
                entity.HasKey(e => e.IdTipoRiesgo);

                entity.Property(e => e.IdTipoRiesgo)
                    .HasColumnName("idTipoRiesgo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DescTipoRiesgo)
                    .HasColumnName("tipoRiesgo")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
