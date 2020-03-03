using GAP.Seguros.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface ITipoRiesgoRepository
    {
        Task<IEnumerable<TipoRiesgo>> GetAll();
        TipoRiesgo Get(byte idTipoRiesgo);
        TipoRiesgo Add(TipoRiesgo TipoRiesgo);
        TipoRiesgo Update(TipoRiesgo TipoRiesgo);
        TipoRiesgo Delete(byte id);
    }
}
