// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 24/11/2021
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
// 0.1	24/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class ProgramaRolPersistencia : IProgramaRolPersistencia
    {
        public async Task<List<Programarol>> GetProgramarolListAsync()
        {
            var programarol = new List<Programarol>();
            return programarol;
        }
        public async Task<Programarol> GetProgramarolByIdAsync(int idProgramarol)
        {
            var programarol = new Programarol();
            return programarol;
        }
        public async Task InsertProgramarol(Programarol programarol)
        {
            programarol = new Programarol();
        }
        public async Task UpdateProgramarol(Programarol programarol)
        {
            programarol = new Programarol();
        }
    }
}
