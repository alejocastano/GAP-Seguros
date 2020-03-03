using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Seguros.Data.Repository
{
    public class PolizaRepository : IPolizaRepository
    {
        private readonly SegurosDbContext context;

        public PolizaRepository(SegurosDbContext context)
        {
            this.context = context;
        }
        public Poliza Add(Poliza poliza)
        {
            throw new NotImplementedException();
        }

        public Poliza Delete(int idPoliza)
        {
            throw new NotImplementedException();
        }

        public Poliza Get(int idPoliza)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Poliza> GetAll()
        {
            throw new NotImplementedException();
        }

        public Poliza Update(Poliza poliza)
        {
            throw new NotImplementedException();
        }
    }
}
