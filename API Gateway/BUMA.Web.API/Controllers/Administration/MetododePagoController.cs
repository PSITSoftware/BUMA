// ==================================================================================
// Desarrollado Por	    : Edwin Andres FLOREZ
// Fecha de Creación	: 29/10/2021
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
// 0.1	29/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


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

    public class MetododePagoController : ApiController
    {
        private readonly IMetodoPagoServicio _metodopagoServicio;
        public MetododePagoController(IMetodoPagoServicio metododepagoServicio)
        {
            _metodopagoServicio = metododepagoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Metodopago/GetMetodopagoList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de metodosdepago", typeof(Metodopago))]
        [HttpGet]
        public async Task<IHttpActionResult> GetMetodopagoListAsync()
        {
            try
            {
                var result = await Task.Run(() => _metodopagoServicio.GetMetodoPagoListAsync());
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
        /// <param name="idMetodopago"></param>
        /// <returns></returns>
        [Route("api/Metodopago/GetMetodopagoById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de metodos de pago", typeof(Metodopago))]
        [HttpGet]
        public async Task<IHttpActionResult> GetMetodopagoByIdAsync(int idMetodopago)
        {
            try
            {
                var result = await Task.Run(() => _metodopagoServicio.GetMetodoPagoByIdAsync(idMetodopago));
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Inserta la informaciòn de la caja
        /// </summary>
        /// <param name="metodopago"></param>
        /// <returns></returns>
        [Route("api/metodopago/InsertMetododepago")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por metodo de pago", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> Insertmetodopago(Metodopago metodopago)
        {
            try
            {
                await _metodopagoServicio.InsertMetodopago(metodopago);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Actualiza la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [Route("api/Metodopago/UpdateMetodopago")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por metododepago", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateMetodopago(Metodopago metodopago)
        {
            try
            {
                await _metodopagoServicio.UpdateMetodopago(metodopago);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
