// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 28/10/2021
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
// 0.1	28/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Negocio;
using buma.negocio.servicios.Interfaces;

namespace buma.negocio.servicios.Inplementaciones
{
   public class InventarioServicio :IInventarioServicio
    {
        public async Task<List<Inventario>> GetInventarioListAsync()
        {
            var inventario = new List<Inventario>();
            return inventario;
        }

        public async Task<Inventario> GetInventarioByIdAsync(int idInventario)
        {
            var inventario = new Inventario();
            return inventario;
        }
        public async Task InsertInventario(Inventario inventario)
        {
            inventario = new Inventario();

        }
        public async Task UpdateInventario(Inventario inventario)
        {
            inventario = new Inventario();
        }

    }
}
