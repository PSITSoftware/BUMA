using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface ICajaPersistencia
    {
        Task<List<Caja>> GetCajaListAsync();
        Task<Caja> GetCajaByIdAsync(int idCaja);
        Task InsertCaja(Caja caja);
        Task UpdateCaja(Caja caja);
    }
}
