using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Repository
{
    public class ClientePolizaRepository : IClientePolizaRepository
    {
        private readonly SegurosDbContext context;

        public ClientePolizaRepository(SegurosDbContext context)
        {
            this.context = context;
        }
        public ClientePoliza Add(ClientePoliza clientePoliza)
        {
            throw new NotImplementedException();
        }

        public ClientePoliza Delete(short idClientePoliza)
        {
            throw new NotImplementedException();
        }

        public ClientePoliza Get(short idClientePoliza)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientePoliza> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientePoliza Update(ClientePoliza clientePoliza)
        {
            throw new NotImplementedException();
        }
    }
}
