// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 26/10/2021
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
// 0.1	26/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Security;
using BUMA.Security.Services.Interfaces;

namespace BUMA.Security.Services.Implementations
{
    public class ProgramarolServicio : IProgramarolServicio
    {
        public async Task<List<Programarol>> GetProgramarolListAsync()
        {
            var programarol = new List<Programarol>();
            return programarol;
        }

        public async Task<Programarol> GetProgramarolByIdAsync(int idUsuario)
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
