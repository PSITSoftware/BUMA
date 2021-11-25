using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class PermisoPersistencia : IPermisoPersistencia
    {
        public async Task<List<Permiso>> GetPermisoListAsync()
        {
            var permiso = new List<Permiso>();
            return permiso;
        }
        public async Task<Permiso> GetPermisoByIdAsync(int idPermiso)
        {
            var permiso = new Permiso();
            return permiso;
        }
        public async Task InsertPermiso(Permiso permiso)
        {
            permiso = new Permiso();
        }
        public async Task UpdatePermiso(Permiso permiso)
        {
            permiso = new Permiso();
        }
    }
}
