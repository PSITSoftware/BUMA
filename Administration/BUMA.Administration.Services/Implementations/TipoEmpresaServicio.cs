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
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;

namespace BUMA.Administration.Services.Implementations
{
    class TipoEmpresaServicio : ITipoEmpresaServicio
    {
        public async Task<List<TipoEmpresa>> GetTipoEmpresaListAsync()
        {
            var tipoempresas = new List<TipoEmpresa>();
            return tipoempresas;
        }

        public async Task<TipoEmpresa> GetTipoEmpresaByIdAsync(int idTipoEmpresa)
        {
            var tipoempresas = new TipoEmpresa();
            return tipoempresas;
        }
        public async Task InsertTipoEmpresa(TipoEmpresa tipoempresas)
        {
            tipoempresas = new TipoEmpresa();

        }
        public async Task UpdateTipoEmpresa(TipoEmpresa regimen)
        {
            regimen = new TipoEmpresa();
        }
    }
}
