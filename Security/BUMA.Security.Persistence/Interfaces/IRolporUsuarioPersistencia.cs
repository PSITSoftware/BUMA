using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Interfaces
{
    public interface IRolporUsuarioPersistencia
    {
        Task<List<RolxUsuario>> GetRolporUsuarioListAsync();
        Task<RolxUsuario> GetRolporUsuarioByIdAsync(int idRolxusuario);
        Task InsertRolporUsuario(RolxUsuario rolporusuario);
        Task UpdateRolporUsuario(RolxUsuario rolporusuario);
    }
}
