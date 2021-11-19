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
   
    public class PermisoController : ApiController
    {
    private readonly IPermisoServicio _permisosServicio; 
    public PermisoController(IPermisoServicio permisiosServicio)
    {
        _permisosServicio = permisiosServicio;
    }

        /// <summary>
        /// Obtiene el listado de todos los Permisos
        /// </summary>
        /// <returns></returns>
        [Route("api/Permiso/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los permisos", typeof(Permiso))]
        [HttpGet]
        public async Task<IHttpActionResult> GetPermisoListAsync()
        {
            try
            {
                var result = await Task.Run(() => _permisosServicio.GetPermisosListAsync());
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
        /// <param name="idpermiso"></param>
        /// <returns></returns>
        [Route("api/Permiso/GetPermisoById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados  de permisos", typeof(Permiso))]
        [HttpGet]
        public async Task<IHttpActionResult> GetpermisoByIdAsync(int idpermiso)
        {
            try
            {
                var result = await Task.Run(() => _permisosServicio.GetPermisosByIdAsync(idpermiso));
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
        /// <param name="permiso"></param>
        /// <returns></returns>
        [Route("api/Permisos/InsertPermisos")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por permiso", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertPermiso(Permiso permiso)
        {
            try
            {
                await _permisosServicio.InsertPermisos(permiso);
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
        /// <param name="permiso"></param>
        /// <returns></returns>
        [Route("api/Permisos/UpdatePermisos")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por permiso", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdatePermisos(Permiso permiso)
        {
            try
            {
                await _permisosServicio.UpdatePermisos(permiso);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }


    }
}
