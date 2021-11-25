using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class RolPersistencia : IRolPersistencia
    {
        public async Task<List<Rol>> GetRolListAsync()
        {
            var rol = new List<Rol>();
            return rol;
        }
        public async Task<Rol> GetRolByIdAsync(int idRol)
        {
            var rol = new Rol();
            return rol;
        }
        public async Task InsertRol(Rol rol)
        {
            rol = new Rol();
        }
        public async Task UpdateRol(Rol rol)
        {
            rol = new Rol();
        }
    }
}
