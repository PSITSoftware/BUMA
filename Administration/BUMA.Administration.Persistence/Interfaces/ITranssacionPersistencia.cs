using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface ITranssacionPersistencia
    {
        Task<List<Trasaccion>> GetTransaccionListAsync();
        Task<Trasaccion> GetTransaccionByIdAsync(int idTransaccion);
        Task InsertTransaccion(Trasaccion transaccion);
        Task UpdateTransaccion(Trasaccion transaccion);
    }
}
