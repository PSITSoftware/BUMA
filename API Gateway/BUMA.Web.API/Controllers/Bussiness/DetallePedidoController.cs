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
using System.Threading.Tasks;
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Bussiness
{
    public class DetallePedidoController : ApiController
    {
        private readonly IDetallePedidoServicio _detallepedidoServicio;
        public DetallePedidoController(IDetallePedidoServicio DetallepedidoServicio)
        {
            _detallepedidoServicio = DetallepedidoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/DetallePedido/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Detalles de pedido", typeof(Detallepedido))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDetallePedidoListAsync()
        {
            try
            {
                var result = await Task.Run(() => _detallepedidoServicio.GetDetallepedidoListAsync());
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
        /// <param name="iddetallepedido"></param>
        /// <returns></returns>
        [Route("api/DetallePedido/GetDetallePedidoById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de detalles de pedido", typeof(Detallepedido))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDetallepedidoByIdAsync(int idDetallepedido)
        {
            try
            {
                var result = await Task.Run(() => _detallepedidoServicio.GetDetallepedidoByIdAsync(idDetallepedido));
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
        /// <param name="detallepedido"></param>
        /// <returns></returns>
        [Route("api/DetallePedido/InsertDetallePedido")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por detalles de pedido", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertDetallepedido(Detallepedido detallepedido)
        {
            try
            {
                await _detallepedidoServicio.InsertDetallepedido(detallepedido);
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
        /// <param name="detallepedido"></param>
        /// <returns></returns>
        [Route("api/detallespedido/UpdateDetallePedido")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por los detalles de pedido", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateDetallePedido(Detallepedido detallepedido)
        {
            try
            {
                await _detallepedidoServicio.UpdateDetallepedido(detallepedido);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}