// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 28/10/2021
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
// 0.1	28/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;
using BUMA.Administration.Persistence.Interfaces;

namespace BUMA.Administration.Services.Implementations
{
    public  class CajaServicio :ICajaServicio
    {
        private readonly ICajaPersistencia _cajaPersistencia;

        public async Task<List<Caja>> GetCajaListAsync()
        {
            return await _cajaPersistencia.GetCajaListAsync();
        }

        public async Task<Caja> GetCajaByIdAsync(int idCaja)
        {
            return await _cajaPersistencia.GetCajaByIdAsync(idCaja);
        }
        public async Task InsertCaja(Caja caja)
        {
            await _cajaPersistencia.InsertCaja(caja);
        }
        public async Task UpdateCaja(Caja caja)
        {
            await _cajaPersistencia.UpdateCaja(caja);
        }
    }
}
