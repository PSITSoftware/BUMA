// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 25/10/2021
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
// 0.1	25/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Security;

namespace BUMA.Security.Services.Interfaces
{
    public interface IModuloServicio
    {
        public Task<List<Modulo>> GetModuloListAsync();

        public Task<Modulo> GetModuloByIdAsync(int idModulo);
        public Task InsertModulo(Modulo modulo);
        public Task UpdateModulo(Modulo modulo);
    }
}
