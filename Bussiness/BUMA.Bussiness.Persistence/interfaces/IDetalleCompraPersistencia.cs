using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IDetalleCompraPersistencia
    {
        Task<List<Detallecompra>> GetDetallecompraListAsync();
        Task<Detallecompra> GetDetallecompraByIdAsync(int iddetallecompra);
        Task InsertDetallecompra(Detallecompra detallecompra);
        Task UpdateDetallecompra(Detallecompra detallecompra);
    }
}
