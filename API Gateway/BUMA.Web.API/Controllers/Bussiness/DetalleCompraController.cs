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

    public class DetalleCompraController : ApiController
    {
        private readonly IDetalleCompraServicio _detallecompraServicio;
        public DetalleCompraController( IDetalleCompraServicio DetallecompraServicio)
        {
            _detallecompraServicio = DetallecompraServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/DetalleCompras/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Detalles de Compras", typeof(Detallecompra))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDetalleComprasListAsync()
        {
            try
            {
                var result = await Task.Run(() => _detallecompraServicio.GetDetallecompraListAsync());
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
        /// <param name="iddetallecompras"></param>
        /// <returns></returns>
        [Route("api/DetalleCompras/GetDetalleComprasById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de detalles de compras", typeof(Detallecompra))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDetalleComprasByIdAsync(int idDetallecompras)
        {
            try
            {
                var result = await Task.Run(() => _detallecompraServicio.GetDetallecompraByIdAsync(idDetallecompras));
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
        /// <param name="detallecompras"></param>
        /// <returns></returns>
        [Route("api/DetalleCompras/InsertDetalleCompras")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por detalles de Compras", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertDetalleCompras(Detallecompra detallecompras)
        {
            try
            {
                await _detallecompraServicio.InsertDetallecompra(detallecompras);
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
        /// <param name="detallecompras"></param>
        /// <returns></returns>
        [Route("api/detallescompras/UpdateDetalleCompras")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por los detalles de compras", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateDetalleCompras(Detallecompra detallecompras)
        {
            try
            {
                await _detallecompraServicio.UpdateDetallecompra(detallecompras);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}