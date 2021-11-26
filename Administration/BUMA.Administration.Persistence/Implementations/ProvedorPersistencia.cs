// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 22/11/2021
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
// 0.1	22/11/2021	    Edwn Andres Florez	    Desarrollo Inicial

using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class ProvedorPersistencia : IProvedorPersistencia
    {

        public async Task<List<Provedor>> GetProvedorListAsync()
        {
            var provedor = new List<Provedor>();
            return provedor;
        }
        public async Task<Provedor> GetProvedorByIdAsync(int idProvedor)
        {
            var provedor = new Provedor();
            return provedor;
        }
        public async Task InsertProvedor(Provedor provedor)
        {
            provedor = new Provedor();
        }
        public async Task UpdateProvedor(Provedor provedor)
        {
            provedor = new Provedor();
        }
    }
}
