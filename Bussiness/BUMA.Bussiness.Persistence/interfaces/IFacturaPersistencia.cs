using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IFacturaPersistencia
    {
        Task<List<Factura>> GetFacturaListAsync();
        Task<Factura> GetFacturaByIdAsync(int idFactura);
        Task InsertFactura(Factura factura);
        Task UpdateFactura(Factura factura);
    }
}
