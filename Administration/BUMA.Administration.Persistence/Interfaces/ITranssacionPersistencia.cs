// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 19/11/2021
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
// 0.1	19/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface ITranssacionPersistencia
    {
        Task<List<Trasaccion>> GetTransaccionListAsync();
        Task<Trasaccion> GetTransaccionByIdAsync(int idTransaccion);
        Task InsertTransaccion(Trasaccion transaccion);
        Task UpdateTransaccion(Trasaccion transaccion);
    }
}
