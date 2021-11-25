using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Interfaces
{
    public interface  IModuloPersistencia
    {
        Task<List<Modulo>> GetModuloListAsync();
        Task<Modulo> GetModuloByIdAsync(int idModulo);
        Task InsertModulo(Modulo modulo);
        Task UpdateModulo(Modulo modulo);
    }
}
