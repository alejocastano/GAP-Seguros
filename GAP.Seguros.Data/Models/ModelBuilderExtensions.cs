using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Seguros.Data.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoRiesgo>().HasData(
                new TipoRiesgo
                {
                    IdTipoRiesgo = 1,
                    DescTipoRiesgo = "Bajo"
                }
                ,
                new TipoRiesgo
                {
                    IdTipoRiesgo = 2,
                    DescTipoRiesgo = "Medio"
                }
                ,
                new TipoRiesgo
                {
                    IdTipoRiesgo = 3,
                    DescTipoRiesgo = "Medio-Alto"
                }
                ,
                new TipoRiesgo
                {
                    IdTipoRiesgo = 4,
                    DescTipoRiesgo = "Alto"
                }
                );

            modelBuilder.Entity<TipoCubrimiento>().HasData(
            new TipoCubrimiento
            {
                IdTipoCubrimiento = 1,
                DescCubrimiento = "Terremoto"

            }
            ,
            new TipoCubrimiento
            {
                IdTipoCubrimiento = 2,
                DescCubrimiento = "Incendio"

            }
            ,
            new TipoCubrimiento
            {
                IdTipoCubrimiento = 3,
                DescCubrimiento = "Robo"

            }
            ,
            new TipoCubrimiento
            {
                IdTipoCubrimiento = 4,
                DescCubrimiento = "Pérdida"

            }
            ,
            new TipoCubrimiento
            {
                IdTipoCubrimiento = 5,
                DescCubrimiento = "Terremoto"

            }
                );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { 
                IdCliente = 1,
                Identificacion = "1020423358",
                Nombre = "Juan Perez"
                }
                ,
                new Cliente
                {
                    IdCliente = 2,
                    Identificacion = "3336655",
                    Nombre = "Alejandra Velez"
                }
                ,
                new Cliente
                {
                    IdCliente = 3,
                    Identificacion = "4445588",
                    Nombre = "Fernanda Uribe"
                }
                ,
                new Cliente
                {
                    IdCliente = 4,
                    Identificacion = "88899663",
                    Nombre = "Fernando Muñoz"
                }
                ,
                new Cliente
                {
                    IdCliente = 5,
                    Identificacion = "111223344",
                    Nombre = "Alejandro Castaño"
                }
                ,
                new Cliente
                {
                    IdCliente = 6,
                    Identificacion = "33322445",
                    Nombre = "Luis Murcia"
                }
                );

        }
    }
}
