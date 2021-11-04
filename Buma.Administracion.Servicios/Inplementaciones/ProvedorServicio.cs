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
    public class ProvedorServicio:IProvedorServicio
    {
        public async Task<List<Provedor>> GetProvedorListAsync()
        {
            var provedor = new List<Provedor>();
            return provedor;
        }

        public async Task<Provedor> GetProvedorByIdAsync(int idprovedor)
        {
            var provedor = new Provedor();
            return provedor;
        }
        public async Task InsertProvedor(Provedor provedor)
        {
            provedor = new Provedor();

        }
        public async Task UpdateProvedor(Provedor provedor)
        {
            provedor = new Provedor();
        }
    }
}
