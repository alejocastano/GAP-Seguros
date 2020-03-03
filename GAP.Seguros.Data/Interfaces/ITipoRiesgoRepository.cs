using GAP.Seguros.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface ITipoRiesgoRepository
    {
        IEnumerable<TipoRiesgo> GetAll();
        TipoRiesgo Get(byte idTipoRiesgo);
        TipoRiesgo Add(TipoRiesgo TipoRiesgo);
        TipoRiesgo Update(TipoRiesgo TipoRiesgo);
        TipoRiesgo Delete(byte id);
    }
}
