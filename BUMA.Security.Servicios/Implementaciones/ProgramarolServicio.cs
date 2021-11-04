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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Seguridad;
using buma.securiy.servicios.Interfaces;

namespace buma.securiy.servicios.Implementaciones
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
