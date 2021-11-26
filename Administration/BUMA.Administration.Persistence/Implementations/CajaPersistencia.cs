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
    public class CajaPersistencia : ICajaPersistencia
    {
        public async Task<List<Caja>> GetCajaListAsync()
        {
            var caja = new List<Caja>();
            return caja;
        }
        public async Task<Caja> GetCajaByIdAsync(int idCaja)
        {
            var caja = new Caja();
            return caja;
        }
        public async Task InsertCaja(Caja caja)
        {
            caja = new Caja();
        }
        public async Task UpdateCaja(Caja caja)
        {
            caja = new Caja();
        }
    }
}
