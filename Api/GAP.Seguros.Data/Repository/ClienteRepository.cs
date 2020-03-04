using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SegurosDbContext context;

        public ClienteRepository(SegurosDbContext context)
        {
            this.context = context;
        }

        public Cliente Add(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente Delete(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente Get(int idCliente)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await context.Cliente.ToListAsync();
        }

        public Cliente Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
