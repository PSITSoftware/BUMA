// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 24/11/2021
// Producto o sistema	: BUMA
// Empresa	: PSIT S.A.S
// Proyecto	: BUMA
// Cliente	: todos
// ==================================================================================
// Versión	Descripción
// 1.0.0.0	<Descripción del archivo>
//
// ==================================================================================
// HISTORIAL DE CAMBIOS:
// =================================================================================
// Ver.	Fecha	        Autor	                Descripción
// ---	-------------	----------------------	-----------------------------------
// 0.1	24/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
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
