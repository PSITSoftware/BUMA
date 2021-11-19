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
    public class SubUbicacionController : ApiController
    {
        private readonly ISubUbicacionServicio _SubUbicacionServicio;
        public SubUbicacionController ( ISubUbicacionServicio sububicacionServicio)
        {
            _SubUbicacionServicio = sububicacionServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/SubUbicacion/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de las subuicaciones ", typeof(Sububicacion))]
        [HttpGet]
        public async Task<IHttpActionResult> GetSubUbicacionListAsync()
        {
            try
            {
                var result = await Task.Run(() => _SubUbicacionServicio.GetSubUbicacionListAsync());
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
        /// <param name="idsububicacion"></param>
        /// <returns></returns>
        [Route("api/SubUbicacion/GetSubUbicacionById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados  de Sububicacion", typeof(Sububicacion))]
        [HttpGet]
        public async Task<IHttpActionResult> GetubicacionByIdAsync(int idsububicacion)
        {
            try
            {
                var result = await Task.Run(() => _SubUbicacionServicio.GetSubUbicacionByIdAsync(idsububicacion));
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
        /// <param name="sububicacion"></param>
        /// <returns></returns>
        [Route("api/SubUbicacion/InsertSubUbicacion")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por sububicacion", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertSubUbicacion(Sububicacion sububicacion)
        {
            try
            {
                await _SubUbicacionServicio.InsertSubUbicacion(sububicacion);
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
        /// <param name="sububicacion"></param>
        /// <returns></returns>
        [Route("api/SubUbicacion/UpdateSudUbicacion")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por la sububicacion", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateDetalleFacturas(Sububicacion sububicacion)
        {
            try
            {
                await _SubUbicacionServicio.UpdateSubUbicacion(sububicacion);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}