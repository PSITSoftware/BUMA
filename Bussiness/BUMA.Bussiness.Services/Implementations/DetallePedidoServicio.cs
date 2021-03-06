// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 27/10/2021
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
// 0.1	27/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;

namespace BUMA.Bussiness.Services.Implementations
{
    public class DetallePedidoServicio : IDetallePedidoServicio
    {
        public async Task<List<Detallepedido>> GetDetallepedidoListAsync()
        {
            var detallepedido = new List<Detallepedido>();
            return detallepedido;
        }

        public async Task<Detallepedido> GetDetallepedidoByIdAsync(int idDetallepedido)
        {
            var detallepedido = new Detallepedido();
            return detallepedido;
        }
        public async Task InsertDetallepedido(Detallepedido detallepedido)
        {
            detallepedido = new Detallepedido();

        }
        public async Task UpdateDetallepedido(Detallepedido detallepedido)
        {
            detallepedido = new Detallepedido();
        }

    }
}
