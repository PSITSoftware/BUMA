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

    public class RolController : ApiController
    {
        private readonly IRolServicio _rolServicio;
        public RolController(IRolServicio rolServicio)
        {
            _rolServicio = rolServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Rol/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Rol", typeof(Rol))]
        [HttpGet]
        public async Task<IHttpActionResult> GetRolListAsync()
        {
            try
            {
                var result = await Task.Run(() => _rolServicio.GetRolListAsync());
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
        /// <param name="idrol"></param>
        /// <returns></returns>
        [Route("api/rol/GetrolById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Rol", typeof(Rol))]
        [HttpGet]
        public async Task<IHttpActionResult> GetRolByIdAsync(int idrol)
        {
            try
            {
                var result = await Task.Run(() => _rolServicio.GetRolByIdAsync(idrol));
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
        /// <param name="rol"></param>
        /// <returns></returns>
        [Route("api/Rol/InsertRol")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por rol", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertRol(Rol rol)
        {
            try
            {
                await _rolServicio.InsertRol(rol);
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
        /// <param name="rol"></param>
        /// <returns></returns>
        [Route("api/Rol/UpdateRol")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por rol", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateRol(Rol rol)
        {
            try
            {
                await _rolServicio.UpdateRol(rol);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
