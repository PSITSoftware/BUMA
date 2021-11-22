using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IMetodoPagoPersistencia
    {
        Task<List<Metodopago>> GetMetodopagoListAsync();
        Task<Metodopago> GetMetodopagoByIdAsync(int idMetodopago);
        Task InsertMetodopago(Metodopago metodopago);
        Task UpdateMetodopago(Metodopago metodopago);
    }
}
