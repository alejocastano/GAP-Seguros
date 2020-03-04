using GAP.Seguros.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface IClientePolizaRepository
    {
        IEnumerable<PolizasClienteView> GetAll();
        Task<ClientePoliza> Get(short idClientePoliza);
        Task<IEnumerable<PolizasClienteView>> GetByCliente(int idCliente);
        Task<ClientePoliza> Add(ClientePoliza clientePoliza);
        Task<ClientePoliza> Update(ClientePoliza clientePoliza);
        Task<ClientePoliza> Delete(ClientePoliza clientePoliza);
    }
}
