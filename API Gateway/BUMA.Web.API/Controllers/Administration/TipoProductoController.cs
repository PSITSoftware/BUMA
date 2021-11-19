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
// 0.1	30/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


using System;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Administration
{
   
    public class TipoProductoController : ApiController
    {

        private readonly   ITipoProductoServicio _tipoproductoServicio;
        public TipoProductoController(ITipoProductoServicio tipoproductoServicio)
        {
            _tipoproductoServicio = tipoproductoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/TipoProducto/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de tipos de producto", typeof(TipoProducto))]
        [HttpGet]
        public async Task<IHttpActionResult> GetTipoProductoListAsync()
        {
            try
            {
                var result = await Task.Run(() => _tipoproductoServicio.GetTipoProductoListAsync());
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
        /// <param name="idtipoproducto"></param>
        /// <returns></returns>
        [Route("api/Tipoproducto/GetTipoproductoById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los tipos de producto", typeof(TipoProducto))]
        [HttpGet]
        public async Task<IHttpActionResult> GetTipoProductoByIdAsync(int idTipoproducto)
        {
            try
            {
                var result = await Task.Run(() => _tipoproductoServicio.GetTipoProductoByIdAsync(idTipoproducto));
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Inserta la informaciòn de la sucursal
        /// </summary>
        /// <param name="tipoproducto"></param>
        /// <returns></returns>
        [Route("api/tipoproducto/InsertTipoproducto")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por tipo de producto", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertTipoProducto(TipoProducto tipoproducto)
        {
            try
            {
                await _tipoproductoServicio.InsertTipoProducto(tipoproducto);
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
        /// <param name="tipoproducto"></param>
        /// <returns></returns>
        [Route("api/TipoProducto/UpdateTipoProducto")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por tipo de producto", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateTipoproducto(TipoProducto tipoproducto)
        {
            try
            {
                await _tipoproductoServicio.UpdateTipoProducto(tipoproducto);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
