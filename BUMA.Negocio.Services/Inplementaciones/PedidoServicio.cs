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
    public class PedidoServicio : IPedidoServicio
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
