﻿// <auto-generated />
using System;
using GAP.Seguros.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GAP.Seguros.Data.Migrations
{
    [DbContext(typeof(SegurosDbContext))]
    [Migration("20200303015851_SeedTipoRiesgo")]
    partial class SeedTipoRiesgo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GAP.Seguros.Data.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idCliente")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Identificacion")
                        .HasColumnName("identificacion")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.ClientePoliza", b =>
                {
                    b.Property<short>("IdClientePoliza")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idClientePoliza")
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Activo")
                        .HasColumnName("activo")
                        .HasColumnType("bit");

                    b.Property<int?>("IdCliente")
                        .HasColumnName("idCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdPoliza")
                        .HasColumnName("idPoliza")
                        .HasColumnType("int");

                    b.HasKey("IdClientePoliza");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdPoliza");

                    b.ToTable("ClientePoliza");
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.Poliza", b =>
                {
                    b.Property<int>("IdPoliza")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idPoliza")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cobertura")
                        .HasColumnName("cobertura")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<byte?>("IdTipoRiesgo")
                        .HasColumnName("idTipoRiesgo")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("InicioVigencia")
                        .HasColumnName("inicioVigencia")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<byte?>("PeriodoCobertura")
                        .HasColumnName("periodoCobertura")
                        .HasColumnType("tinyint");

                    b.Property<decimal?>("Precio")
                        .HasColumnName("precio")
                        .HasColumnType("money");

                    b.HasKey("IdPoliza");

                    b.HasIndex("IdTipoRiesgo");

                    b.ToTable("Poliza");
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.PolizaTiposCubrimiento", b =>
                {
                    b.Property<int>("IdPolizaTiposCubrimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idPolizaTiposCubrimiento")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdPoliza")
                        .HasColumnName("idPoliza")
                        .HasColumnType("int");

                    b.Property<byte?>("IdTipoCubrimiento")
                        .HasColumnName("idTipoCubrimiento")
                        .HasColumnType("tinyint");

                    b.HasKey("IdPolizaTiposCubrimiento");

                    b.HasIndex("IdPoliza");

                    b.HasIndex("IdTipoCubrimiento");

                    b.ToTable("PolizaTiposCubrimiento");
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.TipoCubrimiento", b =>
                {
                    b.Property<byte>("IdTipoCubrimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idTipoCubrimiento")
                        .HasColumnType("tinyint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescCubrimiento")
                        .IsRequired()
                        .HasColumnName("tipoCubrimiento")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdTipoCubrimiento");

                    b.ToTable("TipoCubrimiento");
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.TipoRiesgo", b =>
                {
                    b.Property<byte>("IdTipoRiesgo")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idTipoRiesgo")
                        .HasColumnType("tinyint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescTipoRiesgo")
                        .HasColumnName("tipoRiesgo")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("IdTipoRiesgo");

                    b.ToTable("TipoRiesgo");

                    b.HasData(
                        new
                        {
                            IdTipoRiesgo = (byte)1,
                            DescTipoRiesgo = "Bajo"
                        },
                        new
                        {
                            IdTipoRiesgo = (byte)2,
                            DescTipoRiesgo = "Medio"
                        },
                        new
                        {
                            IdTipoRiesgo = (byte)3,
                            DescTipoRiesgo = "Medio-Alto"
                        },
                        new
                        {
                            IdTipoRiesgo = (byte)4,
                            DescTipoRiesgo = "Alto"
                        });
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.ClientePoliza", b =>
                {
                    b.HasOne("GAP.Seguros.Data.Models.Cliente", "IdClienteNavigation")
                        .WithMany("ClientePoliza")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FK_ClientePoliza_Cliente");

                    b.HasOne("GAP.Seguros.Data.Models.Poliza", "IdPolizaNavigation")
                        .WithMany("ClientePoliza")
                        .HasForeignKey("IdPoliza")
                        .HasConstraintName("FK_ClientePoliza_Poliza");
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.Poliza", b =>
                {
                    b.HasOne("GAP.Seguros.Data.Models.TipoRiesgo", "IdTipoRiesgoNavigation")
                        .WithMany("Poliza")
                        .HasForeignKey("IdTipoRiesgo")
                        .HasConstraintName("FK_Poliza_TipoRiesgo");
                });

            modelBuilder.Entity("GAP.Seguros.Data.Models.PolizaTiposCubrimiento", b =>
                {
                    b.HasOne("GAP.Seguros.Data.Models.Poliza", "IdPolizaNavigation")
                        .WithMany("PolizaTiposCubrimiento")
                        .HasForeignKey("IdPoliza")
                        .HasConstraintName("FK_PolizaTiposCubrimiento_Poliza");

                    b.HasOne("GAP.Seguros.Data.Models.TipoCubrimiento", "IdTipoCubrimientoNavigation")
                        .WithMany("PolizaTiposCubrimiento")
                        .HasForeignKey("IdTipoCubrimiento")
                        .HasConstraintName("FK_PolizaTiposCubrimiento_TipoCubrimiento");
                });
#pragma warning restore 612, 618
        }
    }
}
