using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository
{
    public class TipoRiesgoRepository : ITipoRiesgoRepository
    {
        private readonly SegurosDbContext context;

        public TipoRiesgoRepository(SegurosDbContext context)
        {
            this.context = context;
        }
        public TipoRiesgo Add(TipoRiesgo TipoRiesgo)
        {
            throw new NotImplementedException();
        }

        public TipoRiesgo Delete(byte id)
        {
            throw new NotImplementedException();
        }

        public TipoRiesgo Get(byte idTipoRiesgo)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<TipoRiesgo>> GetAll()
        {
            return await context.TipoRiesgo.ToListAsync();
        }

        public TipoRiesgo Update(TipoRiesgo TipoRiesgo)
        {
            throw new NotImplementedException();
        }

      
    }
}
