using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IPedidoPersistencia
    {
        Task<List<Pedido>> GetPedidoListAsync();
        Task<Pedido> GetPedidoByIdAsync(int idPedido);
        Task InsertPedido(Pedido pedido);
        Task UpdatePedido(Pedido pedido);
    }
}
