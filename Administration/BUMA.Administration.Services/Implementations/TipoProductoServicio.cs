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
    public class TipoProductoServicio : ITipoProductoServicio
    {
        public async Task<List<TipoProducto>> GetTipoProductoListAsync()
        {
            var tipoproducto = new List<TipoProducto>();
            return tipoproducto;
        }

        public async Task<TipoProducto> GetTipoProductoByIdAsync(int idTipoProducto)
        {
            var tipoproducto = new TipoProducto();
            return tipoproducto;
        }
        public async Task InsertTipoProducto(TipoProducto tipoproducto)
        {
            tipoproducto = new TipoProducto();

        }
        public async Task UpdateTipoProducto(TipoProducto tipoproducto)
        {
            tipoproducto = new TipoProducto();
        }
    }
}
