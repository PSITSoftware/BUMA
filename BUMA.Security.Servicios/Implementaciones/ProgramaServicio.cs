// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 25/10/2021
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
using buma.dominio.DTO.Seguridad;
using buma.securiy.servicios.interfaces;
namespace buma.securiy.servicios.Implementaciones
{
    public class ProgramaServicio : IProgramaServicio

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
