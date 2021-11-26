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
    public class ModuloPersistencia : IModuloPersistencia
    {
        public async Task<List<Modulo>> GetModuloListAsync()
        {
            var modulo = new List<Modulo>();
            return modulo;
        }
        public async Task<Modulo> GetModuloByIdAsync(int idModulo)
        {
            var modulo = new Modulo();
            return modulo;
        }
        public async Task InsertModulo(Modulo modulo)
        {
            modulo = new Modulo();
        }
        public async Task UpdateModulo(Modulo modulo)
        {
            modulo = new Modulo();
        }
    }
}
