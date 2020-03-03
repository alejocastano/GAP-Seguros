using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Repository
{
    public class PolizaTiposCubrimientoRepository : IPolizaTiposCubrimientoRepository
    {
        private readonly SegurosDbContext context;

        public PolizaTiposCubrimientoRepository(SegurosDbContext context)
        {
            this.context = context;
        }
        public PolizaTiposCubrimiento Add(PolizaTiposCubrimiento PolizaTiposCubrimiento)
        {
            throw new NotImplementedException();
        }

        public PolizaTiposCubrimiento Delete(int IdPolizaTiposCubrimiento)
        {
            throw new NotImplementedException();
        }

        public PolizaTiposCubrimiento Get(int idPolizaTiposCubrimiento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PolizaTiposCubrimiento> GetAll()
        {
            throw new NotImplementedException();
        }

        public PolizaTiposCubrimiento Update(PolizaTiposCubrimiento PolizaTiposCubrimiento)
        {
            throw new NotImplementedException();
        }
    }
}
