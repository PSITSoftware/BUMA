// ==================================================================================
// Desarrollado Por	    : Edwin Andres FLOREZ
// Fecha de Creación	: 28/10/2021
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
// 0.1	25/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Administration
{
    public class CajaController : ApiController
    {
        private readonly ICajaServicio _cajaServicio;

        public CajaController(ICajaServicio cajaServicio)
        {
            _cajaServicio = cajaServicio;
        }

        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/GetCajaList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de preguntas personalizadas", typeof(Caja))]
        [HttpGet]
        public async Task<IHttpActionResult> GetCajaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _cajaServicio.GetCajaListAsync());
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
        /// <param name="idCaja"></param>
        /// <returns></returns>
        [Route("api/Caja/GetCajaById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de preguntas personalizadas", typeof(Caja))]
        [HttpGet]
        public async Task<IHttpActionResult> GetCajaByIdAsync(int idCaja)
        {
            try
            {
                var result = await Task.Run(() => _cajaServicio.GetCajaByIdAsync(idCaja));
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
        /// <param name="caja"></param>
        /// <returns></returns>
        [Route("api/Caja/InsertCaja")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por guardado de Preguntas Personalizadas", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertCaja(Caja caja)
        {
            try
            {
                await _cajaServicio.InsertCaja(caja);
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
        [Route("api/Caja/UpdateCaja")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por guardado de Preguntas Personalizadas", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateCaja(Caja caja)
        {
            try
            {
                await _cajaServicio.UpdateCaja(caja);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
