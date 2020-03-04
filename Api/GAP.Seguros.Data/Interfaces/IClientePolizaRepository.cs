using GAP.Seguros.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface IClientePolizaRepository
    {
        IEnumerable<ClientePoliza> GetAll();
        ClientePoliza Get(short idClientePoliza);
        Task<ClientePoliza> Add(ClientePoliza clientePoliza);


        ClientePoliza Update(ClientePoliza clientePoliza);
        ClientePoliza Delete(short idClientePoliza);
    }
}
