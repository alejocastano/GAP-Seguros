using GAP.Seguros.Data.Models;
using System.Collections.Generic;

namespace GAP.Seguros.Data.Repository.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();
        Cliente Get(int idCliente);
        Cliente Add(Cliente cliente);
        Cliente Update(Cliente cliente);
        Cliente Delete(int idCliente);
    }
}
