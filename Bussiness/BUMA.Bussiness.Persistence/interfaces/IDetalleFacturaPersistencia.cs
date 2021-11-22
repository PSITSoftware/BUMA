using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IDetalleFacturaPersistencia
    {
        Task<List<Detallefactura>> GetDetallefacturaListAsync();
        Task<Detallefactura> GetDetallefacturaByIdAsync(int idDetallefactura);
        Task InsertDetallefactura(Detallefactura detallefactura);
        Task UpdateDetallefactura(Detallefactura detallefactura);
    }
}
