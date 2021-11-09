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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;

namespace BUMA.Administration.Services.Implementations
{
    public class ControlServicio :IControlServicio
    {
        public async Task<List<Control>> GetControlListAsync()
        {
            var Control = new List<Control>();
            return Control;
        }

        public async Task<Control> GetControlByIdAsync(int idControl)
        {
            var control = new Control();
            return control;
        }
        public async Task InsertControl(Control control)
        {
            control = new Control();

        }
        public async Task UpdateControl(Control control)
        {
            control = new Control();
        }
    }
}
