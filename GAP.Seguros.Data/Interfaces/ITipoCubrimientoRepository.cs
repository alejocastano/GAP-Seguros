using GAP.Seguros.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface ITipoCubrimientoRepository
    {
        IEnumerable<TipoCubrimiento> GetAll();
        TipoCubrimiento Get(byte idTipoCubrimiento);
        TipoCubrimiento Add(TipoCubrimiento TipoCubrimiento);
        TipoCubrimiento Update(TipoCubrimiento TipoCubrimiento);
        TipoCubrimiento Delete(byte idTipoCubrimiento);
    }
}
