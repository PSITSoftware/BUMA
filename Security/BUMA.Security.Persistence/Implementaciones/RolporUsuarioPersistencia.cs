using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class RolporUsuarioPersistencia : IRolporUsuarioPersistencia
    {
        public async Task<List<RolxUsuario>> GetRolporUsuarioListAsync()
        {
            var rolporusuario = new List<RolxUsuario>();
            return rolporusuario;
        }
        public async Task<RolxUsuario> GetRolporUsuarioByIdAsync(int idRolporusuario)
        {
            var rolporusuario = new RolxUsuario();
            return rolporusuario;
        }
        public async Task InsertRolporUsuario(RolxUsuario rolporusuario)
        {
            rolporusuario = new RolxUsuario();
        }
        public async Task UpdateRolporUsuario(RolxUsuario rolporusuario)
        {
            rolporusuario = new RolxUsuario();
        }
    }
}
