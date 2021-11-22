using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IClientePersistencia
    {
        Task<List<Cliente>> GetClienteListAsync();
        Task<Cliente> GetClienteByIdAsync(int idCliente);
        Task InsertCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
    }
}
