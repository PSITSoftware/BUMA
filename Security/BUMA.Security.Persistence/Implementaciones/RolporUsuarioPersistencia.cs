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
