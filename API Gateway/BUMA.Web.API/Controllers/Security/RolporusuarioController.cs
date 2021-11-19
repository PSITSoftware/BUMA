// ==================================================================================
// Desarrollado Por	    : Silvio Alejandro Reyes Jota
// Fecha de Creación	: 20/10/2021
// Producto o sistema	: PIDT
// Empresa	: Tecna ICE S.A
// Proyecto	: PIDT 6
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
// 0.1	20/10/2021	    Silvio Alejandro Reyes Jota	    Desarrollo Inicial


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


    public class RolporusuarioController : ApiController
    {
        private readonly IRolporusuarioServicio _rolporusuarioServicio;
        public RolporusuarioController(IRolporusuarioServicio RolporusuarioServicio)
        {
            _rolporusuarioServicio = RolporusuarioServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Rolporusuario/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Rol por usuario", typeof(RolxUsuario))]
        [HttpGet]
        public async Task<IHttpActionResult> GetRolporusuarioListAsync()
        {
            try
            {
                var result = await Task.Run(() => _rolporusuarioServicio.GetRolporUsuarioListAsync());
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
        /// <param name="idrolporusuario"></param>
        /// <returns></returns>
        [Route("api/rolporusuario/GetrolporusuarioById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Rol por usuario", typeof(RolxUsuario))]
        [HttpGet]
        public async Task<IHttpActionResult> GetRolporusuarioByIdAsync(int idrolporusuario)
        {
            try
            {
                var result = await Task.Run(() => _rolporusuarioServicio.GetRolporUsuarioByIdAsync(idrolporusuario));
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
        /// <param name="rolporusuario"></param>
        /// <returns></returns>
        [Route("api/Rolporusuario/InsertRolporUsuario")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por rol por usuario", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertRolporUsuario(RolxUsuario rolporusuario)
        {
            try
            {
                await _rolporusuarioServicio.InsertRolporUsuario(rolporusuario);
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
        /// <param name="rolporusuario"></param>
        /// <returns></returns>
        [Route("api/Rolporusuario/UpdateRolporUsuario")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por rolporusuario", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateRolporUsuario(RolxUsuario rolporusuario)
        {
            try
            {
                await _rolporusuarioServicio.UpdateRolporUsuario(rolporusuario);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
