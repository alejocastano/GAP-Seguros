using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
