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

    

    public class ComprasController : ApiController
    {
        private readonly IComprasServicio _comprasServicio;
        public ComprasController(IComprasServicio comprasServicio)
        {
            _comprasServicio = comprasServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Compras/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de Compras", typeof(Compras))]
        [HttpGet]
        public async Task<IHttpActionResult> GetComprasListAsync()
        {
            try
            {
                var result = await Task.Run(() => _comprasServicio.GetComprasListAsync());
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
        /// <param name="idcompras"></param>
        /// <returns></returns>
        [Route("api/Compras/GetComprasById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de compras", typeof(Compras))]
        [HttpGet]
        public async Task<IHttpActionResult> GetComprasByIdAsync(int idCompras)
        {
            try
            {
                var result = await Task.Run(() => _comprasServicio.GetComprasByIdAsync(idCompras));
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
        /// <param name="compras"></param>
        /// <returns></returns>
        [Route("api/Compras/InsertCompras")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Compras", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertCompras(Compras compras)
        {
            try
            {
                await _comprasServicio.InsertCompras(compras);
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
        /// <param name="compras"></param>
        /// <returns></returns>
        [Route("api/compras/UpdateCompras")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por las compras", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateCompras(Compras compras)
        {
            try
            {
                await _comprasServicio.UpdateCompras(compras);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
