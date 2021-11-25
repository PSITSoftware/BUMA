using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Interfaces
{
    public interface IRolPersistencia
    {
        Task<List<Rol>> GetRolListAsync();
        Task<Rol> GetRolByIdAsync(int idRol);
        Task InsertRol(Rol rol);
        Task UpdateRol(Rol rol);
    }
}
