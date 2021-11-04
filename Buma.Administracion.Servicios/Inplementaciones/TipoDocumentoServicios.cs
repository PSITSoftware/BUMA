// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 30/10/2021
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Administracion;
using Buma.Administracion.servicios.Interfaces;

namespace Buma.Administracion.servicios.Inplementaciones
{
    public class TipoDocumentoServicios : ITipoDocumentoServicio
    {
        public async Task<List<Tipodocumento>> GetTipodocumentoListAsync()
        {
            var tipodocumento = new List<Tipodocumento>();
            return tipodocumento;
        }

        public async Task<Tipodocumento> GetTipodocumentoByIdAsync(int idTipodocumento)
        {
            var tipodocumento = new Tipodocumento();
            return tipodocumento;
        }
        public async Task InsertTipodocumento(Tipodocumento tipodocumento)
        {
            tipodocumento = new Tipodocumento();

        }
        public async Task UpdateTipodocumento(Tipodocumento regimen)
        {
            regimen = new Tipodocumento();
        }
    }
}
