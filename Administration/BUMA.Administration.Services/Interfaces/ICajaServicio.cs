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

namespace BUMA.Administration.Services.Interfaces
{
    public interface ICajaServicio
    {
        Task<List<Caja>> GetCajaListAsync();
        Task<Caja> GetCajaByIdAsync(int idCaja);
        Task InsertCaja(Caja caja);
        Task UpdateCaja(Caja caja);
    }
}
