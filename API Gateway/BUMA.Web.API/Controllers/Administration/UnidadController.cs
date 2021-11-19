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
    
    public class UnidadController : ApiController
    {
        private readonly IUnidadServicio _unidadServicio;
        public UnidadController(IUnidadServicio unidadServicio)
        {
            _unidadServicio = unidadServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Unidad/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de Unidad", typeof(Unidad))]
        [HttpGet]
        public async Task<IHttpActionResult> GetUnidadListAsync()
        {
            try
            {
                var result = await Task.Run(() => _unidadServicio.GetUnidadListAsync());
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
        /// <param name="idunidad"></param>
        /// <returns></returns>
        [Route("api/Unidad/GetUnidadById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de Unidades", typeof(Unidad))]
        [HttpGet]
        public async Task<IHttpActionResult> GetUnidadByIdAsync(int idUnidad)
        {
            try
            {
                var result = await Task.Run(() => _unidadServicio.GetUnidadByIdAsync(idUnidad));
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
        /// <param name="unidad"></param>
        /// <returns></returns>
        [Route("api/Unidad/InsertUnidad")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por unidades", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertUnidad(Unidad unidad)
        {
            try
            {
                await _unidadServicio.InsertUnidad(unidad);
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
        /// <param name="unidad"></param>
        /// <returns></returns>
        [Route("api/unidad/UpdateUnidad")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Unidad", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateUnidad(Unidad unidad)
        {
            try
            {
                await _unidadServicio.UpdateUnidad(unidad);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
