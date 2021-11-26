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
    public class PedidoPersistencia : IPedidoPersistencia
    {
        public async Task<List<Pedido>> GetPedidoListAsync()
        {
            var pedido = new List<Pedido>();
            return pedido;
        }
        public async Task<Pedido> GetPedidoByIdAsync(int idPedido)
        {
            var pedido = new Pedido();
            return pedido;
        }
        public async Task InsertPedido(Pedido pedido)
        {
            pedido = new Pedido();
        }
        public async Task UpdatePedido(Pedido pedido)
        {
            pedido = new Pedido();
        }
    }
}
