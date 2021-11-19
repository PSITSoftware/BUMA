// =// ==================================================================================
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
// 0.1	28/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


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
    public class LicenciaController : ApiController
    {
        private readonly ILicenciaServicio _licenciaServicio;
        public LicenciaController(ILicenciaServicio licenciaServicio)
        {
            _licenciaServicio = licenciaServicio;
        }


        [Route("api/Insumo/GetLicecniaList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de licencias", typeof(Licencia))]
        [HttpGet]
        public async Task<IHttpActionResult> GetLicenciaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _licenciaServicio.GetLicenciaListAsync());
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
        /// <param name="idLicencia"></param>
        /// <returns></returns>
        [Route("api/Licencia/GetLicenciaById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de preguntas personalizadas", typeof(Licencia))]
        [HttpGet]
        public async Task<IHttpActionResult> GetLicenciaByIdAsync(int idLicencia)
        {
            try
            {
                var result = await Task.Run(() => _licenciaServicio.GetLicenciaByIdAsync(idLicencia));
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
        /// <param name="licencia"></param>
        /// <returns></returns>
        [Route("api/licencia/InsertLicencia")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por licencia", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertLicencia(Licencia licencia)
        {
            try
            {
                await _licenciaServicio.InsertLicencia(licencia);
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
        /// <param name="licencia"></param>
        /// <returns></returns>
        [Route("api/Licencia/UpdateLicencia")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por licencia", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateLicencia(Licencia licencia)
        {
            try
            {
                await _licenciaServicio.UpdateLicencia(licencia);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
