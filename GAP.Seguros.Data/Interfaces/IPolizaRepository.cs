using GAP.Seguros.Data.Models;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface IPolizaRepository
    {
        IEnumerable<Poliza> GetAll();
        Poliza Get(int idPoliza);
        Poliza Add(Poliza poliza);
        Poliza Update(Poliza poliza);
        Poliza Delete(int idPoliza);
    }
}
