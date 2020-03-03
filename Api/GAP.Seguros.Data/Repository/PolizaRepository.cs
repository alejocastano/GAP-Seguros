using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository
{
    public class PolizaRepository : IPolizaRepository
    {
        private readonly SegurosDbContext context;

        public PolizaRepository(SegurosDbContext context)
        {
            this.context = context;
        }

        public async Task<Poliza> Add(Poliza poliza)
        {
            context.Poliza.Add(poliza);
            await context.SaveChangesAsync();
            return poliza;
        }

        public async Task<Poliza> Delete(Poliza poliza)
        {
            context.Poliza.Remove(poliza);
            await context.SaveChangesAsync();
            return poliza;
        }

        public async Task<Poliza> Get(int idPoliza)
        {
            return await context.Poliza.FirstOrDefaultAsync(x => x.IdPoliza == idPoliza);
        }

        public async Task<IEnumerable<Poliza>> GetAll()
        {
            return await context.Poliza.ToListAsync();
        }

        public async Task<Poliza> Update(Poliza poliza)
        {
            context.Entry(poliza).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return poliza;

        }
    }
}
