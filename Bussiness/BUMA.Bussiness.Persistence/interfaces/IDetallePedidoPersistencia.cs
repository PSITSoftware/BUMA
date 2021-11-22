using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IDetallePedidoPersistencia
    {
        Task<List<Detallepedido>> GetDetallepedidoListAsync();
        Task<Detallepedido> GetDetallepedidoByIdAsync(int idDetallepedido);
        Task InsertDetallepedido(Detallepedido detallepedido);
        Task UpdateDetallepedido(Detallepedido detallepedido);
    }
}
