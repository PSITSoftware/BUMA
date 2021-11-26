// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 22/11/2021
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
// 0.1	22/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class ProductoPersistencia
    {
        public async Task<List<producto>> GetProductoListAsync()
        {
            var producto = new List<producto>();
            return producto;
        }
        public async Task<producto> GetProductoByIdAsync(int idProvedor)
        {
            var producto = new producto();
            return producto;
        }
        public async Task InsertProducto(producto producto)
        {
            producto = new producto();
        }
        public async Task UpdateProducto(producto producto)
        {
            producto = new producto();
        }
    }
}
