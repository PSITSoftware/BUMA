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
using buma.dominio.DTO.Administracion;
using Buma.Administracion.servicios.Interfaces;

namespace Buma.Administracion.servicios.Inplementaciones
{
    public class EmpresaServicio :IEmpresaServicio
    {
        public async Task<List<Empresa>> GetEmpresaListAsync()
        {
            var empresa = new List<Empresa>();
            return empresa;
        }

        public async Task<Empresa> GetEmpresaByIdAsync(int idEmpresa)
        {
            var empresa = new Empresa();
            return empresa;
        }
        public async Task InsertEmpresa(Empresa empresa)
        {
            empresa = new Empresa();
        }
        public async Task UpdateEmpresa(Empresa empresa)
        {
            empresa = new Empresa();
        }
    }
}
