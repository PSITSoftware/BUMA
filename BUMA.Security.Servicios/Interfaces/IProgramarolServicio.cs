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

namespace buma.securiy.servicios.Interfaces
{
    public interface IProgramarolServicio
    {
        public Task<List<Programarol>> GetProgramarolListAsync();

        public Task<Programarol> GetProgramarolByIdAsync(int idProgramarol);
        public Task InsertProgramarol(Programarol programarol);
        public Task UpdateProgramarol(Programarol programarol);
    }
}
