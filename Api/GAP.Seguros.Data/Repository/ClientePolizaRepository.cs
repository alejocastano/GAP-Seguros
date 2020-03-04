using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository
{
    public class ClientePolizaRepository : IClientePolizaRepository
    {
        private readonly SegurosDbContext context;

        public ClientePolizaRepository(SegurosDbContext context)
        {
            this.context = context;
        }
        public async Task<ClientePoliza> Add(ClientePoliza clientePoliza)
        {
            context.ClientePoliza.Add(clientePoliza);
            await context.SaveChangesAsync();
            return clientePoliza;
        }

        public async Task<ClientePoliza> Delete(ClientePoliza clientePoliza)
        {
            context.ClientePoliza.Remove(clientePoliza);
            await context.SaveChangesAsync();
            return clientePoliza;
        }

        public async Task<ClientePoliza> Get(short idClientePoliza)
        {
            return await context.ClientePoliza.FirstOrDefaultAsync(x => x.IdClientePoliza == idClientePoliza);
        }

        public IEnumerable<PolizasClienteView> GetAll()
        {
            var resultado = from a in context.ClientePoliza
                            join b in context.Poliza on a.IdPoliza equals b.IdPoliza
                            join c in context.Cliente on a.IdCliente equals c.IdCliente
                            select new PolizasClienteView
                            {
                                IdClientePoliza = a.IdClientePoliza,
                                IdPoliza = b.IdPoliza,
                                NombrePoliza = b.Nombre,
                                IdCliente = c.IdCliente,
                                Identificacion = c.Identificacion,
                                Nombre = c.Nombre,
                                Activo = a.Activo
                            };

            return resultado;
        }

        public async Task<IEnumerable<PolizasClienteView>> GetByCliente(int idCliente)
        {
            var resultado = await (from a in context.ClientePoliza
                             join b in context.Poliza on a.IdPoliza equals b.IdPoliza
                             join c in context.Cliente on a.IdCliente equals c.IdCliente
                             where a.IdCliente == idCliente
                             select new PolizasClienteView
                             {
                                 IdClientePoliza = a.IdClientePoliza,
                                 IdPoliza = b.IdPoliza,
                                 NombrePoliza = b.Nombre,
                                 IdCliente = c.IdCliente,
                                 Identificacion = c.Identificacion,
                                 Nombre = c.Nombre,
                                 Activo = a.Activo
                             }).ToListAsync();

            return resultado;
        }

        public async Task<ClientePoliza> Update(ClientePoliza clientePoliza)
        {
            context.Entry(clientePoliza).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return clientePoliza;
        }
    }
}
