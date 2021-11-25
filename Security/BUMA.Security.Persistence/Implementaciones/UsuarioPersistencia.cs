using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class UsuarioPersistencia : IUsuarioPersistencia
    {
        public async Task<List<Usuario>> GetUsuarioListAsync()
        {
            var usuario = new List<Usuario>();
            return usuario;
        }
        public async Task<Usuario> GetUsuarioByIdAsync(int idUsuario)
        {
            var usuario = new Usuario();
            return usuario;
        }
        public async Task InsertUsuario(Usuario usuario)
        {
            usuario = new Usuario();
        }
        public async Task UpdateUsuario(Usuario usuario)
        {
            usuario = new Usuario();
        }
    }
}
