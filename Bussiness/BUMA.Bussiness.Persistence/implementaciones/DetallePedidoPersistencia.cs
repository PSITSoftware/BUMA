using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class DetallePedidoPersistencia : IDetallePedidoPersistencia
    {
        public async Task<List<Detallepedido>> GetDetallepedidoListAsync()
        {
            var detallepedido = new List<Detallepedido>();
            return detallepedido;
        }
        public async Task<Detallepedido> GetDetallepedidoByIdAsync(int idDetallepedido)
        {
            var detallepedido = new Detallepedido();
            return detallepedido;
        }
        public async Task InsertDetallepedido(Detallepedido detallepedido)
        {
            detallepedido = new Detallepedido();
        }
        public async Task UpdateDetallepedido(Detallepedido detallepedido)
        {
            detallepedido = new Detallepedido();
        }
    }
}
