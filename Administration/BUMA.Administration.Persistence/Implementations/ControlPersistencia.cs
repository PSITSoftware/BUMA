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
    public class ControlPersistencia : IControlPersistencia
    {
        public async Task<List<Control>> GetControlListAsync()
        {
            var control = new List<Control>();
            return control;
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
