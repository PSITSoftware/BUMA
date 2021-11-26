// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 23/11/2021
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
// 0.1	23/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class InventarioPersistencia : IInventarioPersistencia
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
