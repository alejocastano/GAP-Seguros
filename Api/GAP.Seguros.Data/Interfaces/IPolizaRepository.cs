using GAP.Seguros.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface IPolizaRepository
    {
        Task<IEnumerable<Poliza>> GetAll();
        Task<Poliza> Get(int idPoliza);
        Task<Poliza> Add(Poliza poliza);
        Task<Poliza> Update(Poliza poliza);
        Task<Poliza> Delete(Poliza poliza);
    }
}
