using GAP.Seguros.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface ITipoCubrimientoRepository
    {
        Task<IEnumerable<TipoCubrimiento>> GetAll();
        TipoCubrimiento Get(byte idTipoCubrimiento);
        TipoCubrimiento Add(TipoCubrimiento TipoCubrimiento);
        TipoCubrimiento Update(TipoCubrimiento TipoCubrimiento);
        TipoCubrimiento Delete(byte idTipoCubrimiento);
    }
}
