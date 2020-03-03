using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository
{
    public class TipoCubrimientoRepository : ITipoCubrimientoRepository
    {
        private readonly SegurosDbContext context;

        public TipoCubrimientoRepository(SegurosDbContext context)
        {
            this.context = context;
        }
        public TipoCubrimiento Add(TipoCubrimiento TipoCubrimiento)
        {
            throw new NotImplementedException();
        }

        public TipoCubrimiento Delete(byte idTipoCubrimiento)
        {
            throw new NotImplementedException();
        }

        public TipoCubrimiento Get(byte idTipoCubrimiento)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TipoCubrimiento>> GetAll()
        {
            return await context.TipoCubrimiento.ToListAsync();
        }

        public TipoCubrimiento Update(TipoCubrimiento TipoCubrimiento)
        {
            throw new NotImplementedException();
        }
    }
}
