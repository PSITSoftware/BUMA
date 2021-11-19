// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 25/10/2021
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
// 0.1	25/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Security;
using BUMA.Security.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Security
{

    public class ModuloController : ApiController
    {
        private readonly IModuloServicio _moduloServicio;
        public ModuloController(IModuloServicio moduloServicio)
        {
            _moduloServicio = moduloServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Modulos
        /// </summary>
        /// <returns></returns>
        [Route("api/Modulo/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los ", typeof(Modulo))]
        [HttpGet]
        public async Task<IHttpActionResult> GetSubUbicacionListAsync()
        {
            try
            {
                var result = await Task.Run(() => _moduloServicio.GetModuloListAsync());
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
        /// <param name="idmodulo"></param>
        /// <returns></returns>
        [Route("api/Modulo/GetModuloById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados  de modulo", typeof(Modulo))]
        [HttpGet]
        public async Task<IHttpActionResult> GetmoduloByIdAsync(int idmodulo)
        {
            try
            {
                var result = await Task.Run(() => _moduloServicio.GetModuloByIdAsync(idmodulo));
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
        /// <param name="modulo"></param>
        /// <returns></returns>
        [Route("api/SubUbicacion/InsertSubUbicacion")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por modulo", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertModulo(Modulo modulo)
        {
            try
            {
                await _moduloServicio.InsertModulo(modulo);
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
        /// <param name="modulo"></param>
        /// <returns></returns>
        [Route("api/modulo/Updatemodulo")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por el modulo", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateModulo(Modulo modulo)
        {
            try
            {
                await _moduloServicio.UpdateModulo(modulo);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
