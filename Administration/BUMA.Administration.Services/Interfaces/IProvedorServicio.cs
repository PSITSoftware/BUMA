// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 29/10/2021
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
// 0.1	29/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;

namespace BUMA.Administration.Services.Interfaces
{
    public interface IProvedorServicio
    {
        public Task<List<Provedor>> GetProvedorListAsync();

        public Task<Provedor> GetProvedorByIdAsync(int idProvedor);
        public Task InsertProvedor(Provedor provedor);
        public Task UpdateProvedor(Provedor provedor);
    }
}
