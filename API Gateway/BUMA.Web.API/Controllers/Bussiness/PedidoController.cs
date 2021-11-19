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
using System.Threading.Tasks;
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Bussiness
{
   
    public class PedidoController : ApiController
    {
        private readonly IPedidoServicio _PedidoServicio;
        public PedidoController(IPedidoServicio pedidoServicio)
        {
            _PedidoServicio = pedidoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
      
        
        [Route("api/Pedido/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los pedidos", typeof(Pedido))]
        [HttpGet]
        public async Task<IHttpActionResult> GetPedidoListAsync()
        {
            try
            {
                var result = await Task.Run(() => _PedidoServicio.GetPedidoListAsync());
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Obtiene los Caja por Identificador
        /// </summary>
        /// <param name="idpedido"></param>
        /// <returns></returns>
        [Route("api/Pedido/GetPedidoById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de pedido", typeof(Pedido))]
        [HttpGet]
        public async Task<IHttpActionResult> GetPedidoByIdAsync(int idpedido)
        {
            try
            {
                var result = await Task.Run(() => _PedidoServicio.GetPedidoByIdAsync(idpedido));
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Inserta la informaciòn de los clientes
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        [Route("api/Pedido/InsertPedido")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por pedido", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> Insertpedido(Pedido pedido)
        {
            try
            {
                await _PedidoServicio.InsertPedido(pedido);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Actualiza la informaciòn de la sucursal
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        [Route("api/pedido/UpdatePedido")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por los pedido", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdatePedido(Pedido pedido)
        {
            try
            {
                await _PedidoServicio.UpdatePedido(pedido);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
