// ==================================================================================
// Desarrollado Por	    : Silvio Alejandro Reyes Jota
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
// Ver.	Fecha	        Autor	                            Descripción
// ---	-------------	----------------------	-----------------------------------
// 0.1	 25/10/2021	    Silvio A. Reyes J.             Desarrollo Inicial

using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Security;
using BUMA.Security.Services.Interfaces;

namespace BUMA.Security.Services.Implementations
{
    public class ModuloServicio : IModuloServicio
    {
        public async Task<List<Modulo>> GetModuloListAsync()
        {
            var modulos = new List<Modulo>();
            return modulos;
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
