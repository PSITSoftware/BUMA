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
    public class ProgramaPersistencia : IProgramaPersistencia
    {
        public async Task<List<Programa>> GetProgramaListAsync()
        {
            var programa = new List<Programa>();
            return programa;
        }
        public async Task<Programa> GetProgramaByIdAsync(int idPrograma)
        {
            var programa = new Programa();
            return programa;
        }
        public async Task InsertPrograma(Programa programa)
        {
            programa = new Programa();
        }
        public async Task UpdatePrograma(Programa programa)
        {
            programa = new Programa();
        }
    }
}
