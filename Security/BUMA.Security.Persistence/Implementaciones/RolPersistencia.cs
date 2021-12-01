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
// 0.1	24/11/2021	    Edwn Andres Florez	    Desarrollo Inicialusing BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using BUMA.Security.Persistence.Interfaces;
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
