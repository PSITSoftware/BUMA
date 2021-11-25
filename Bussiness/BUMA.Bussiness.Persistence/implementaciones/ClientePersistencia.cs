using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class ClientePersistencia :IClientePersistencia
    {
        public async Task<List<Cliente>> GetClienteListAsync()
        {
            var cliente = new List<Cliente>();
            return cliente;
        }
        public async Task<Cliente> GetClienteByIdAsync(int idCliente)
        {
            var cliente = new Cliente();
            return cliente;
        }
        public async Task InsertCliente(Cliente cliente)
        {
            cliente = new Cliente();
        }
        public async Task UpdateCliente(Cliente cliente)
        {
            cliente = new Cliente();
        }
    }
}
