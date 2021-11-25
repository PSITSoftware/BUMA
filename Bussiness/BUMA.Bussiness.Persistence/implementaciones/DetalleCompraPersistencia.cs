using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class DetalleCompraPersistencia : IDetalleCompraPersistencia
    {
        public async Task<List<Detallecompra>> GetDetallecompraListAsync()
        {
            var detallecompra = new List<Detallecompra>();
            return detallecompra;
        }
        public async Task<Detallecompra> GetDetallecompraByIdAsync(int idDetallecompra)
        {
            var detallecompra = new Detallecompra();
            return detallecompra;
        }
        public async Task InsertDetallecompra(Detallecompra detallecompra)
        {
            detallecompra = new Detallecompra();
        }
        public async Task UpdateDetallecompra(Detallecompra detallecompra)
        {
            detallecompra = new Detallecompra();
        }
    }
}
