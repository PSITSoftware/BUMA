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
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Administration

{

    public class RegimenController : ApiController
    {
        private readonly IRegimenServicio _regimenServicio;
        public RegimenController(IRegimenServicio regimenServicio)
        {
            _regimenServicio = regimenServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Regimen/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de regimenes", typeof(Regimen))]
        [HttpGet]
        public async Task<IHttpActionResult> GetRegimenListAsync()
        {
            try
            {
                var result = await Task.Run(() => _regimenServicio.GetRegimenListAsync());
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
        /// <param name="idregimen"></param>
        /// <returns></returns>
        [Route("api/Regimen/GetRegiemnById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de regimenes", typeof(Regimen))]
        [HttpGet]
        public async Task<IHttpActionResult> GetRegimenByIdAsync(int idRegimen)
        {
            try
            {
                var result = await Task.Run(() => _regimenServicio.GetRegimenByIdAsync(idRegimen));
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
        /// <param name="regimen"></param>
        /// <returns></returns>
        [Route("api/regimen/InsertRegimen")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por regimen", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertRegimen(Regimen regimen)
        {
            try
            {
                await _regimenServicio.InsertRegimen(regimen);
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
        /// <param name="regimen"></param>
        /// <returns></returns>
        [Route("api/Regimen/UpdateRegimen")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Regimen", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateRegimen(Regimen regimen)
        {
            try
            {
                await _regimenServicio.UpdateRegimen(regimen);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
