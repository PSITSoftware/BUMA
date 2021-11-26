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
    public class TipoDocumentoPersistencia : ITipoDocumentoPersistencia
    {
        public async Task<List<Tipodocumento>> GetTipoDocumentoListAsync()
        {
            var tipodocumento = new List<Tipodocumento>();
            return tipodocumento;
        }
        public async Task<Tipodocumento> GetTipoDocumentoByIdAsync(int idTipodocumento)
        {
            var tipodocumento = new Tipodocumento();
            return tipodocumento;
        }
        public async Task InsertTipoDocumento(Tipodocumento tipodocumento)
        {
            tipodocumento = new Tipodocumento();
        }
        public async Task UpdateTipoDocumento(Tipodocumento tipodocumento)
        {
            tipodocumento = new Tipodocumento();
        }
    }
}
