using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Interfaces
{
    public interface IPermisoPersistencia
    {
        Task<List<Permiso>> GetPermisoListAsync();
        Task<Permiso> GetPermisoByIdAsync(int idPermiso);
        Task InsertPermiso(Permiso permiso);
        Task UpdatePermiso(Permiso permiso);
    }
}
