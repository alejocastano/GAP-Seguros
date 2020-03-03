using GAP.Seguros.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface IPolizaTiposCubrimientoRepository
    {
        IEnumerable<PolizaTiposCubrimiento> GetAll();
        PolizaTiposCubrimiento Get(int idPolizaTiposCubrimiento);
        PolizaTiposCubrimiento Add(PolizaTiposCubrimiento PolizaTiposCubrimiento);
        PolizaTiposCubrimiento Update(PolizaTiposCubrimiento PolizaTiposCubrimiento);
        PolizaTiposCubrimiento Delete(int IdPolizaTiposCubrimiento);
    }
}
