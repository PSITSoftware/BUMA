using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Interfaces
{
    public interface IUsuarioPersistencia
    {
        Task<List<Usuario>> GetUsuarioListAsync();
        Task<Usuario> GetUsuarioByIdAsync(int idUsuario);
        Task InsertUsuario(Usuario usuario);
        Task UpdateUsuario(Usuario usuario);
    }
}
