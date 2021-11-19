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

namespace psit.BUMA.Web.API.Controllers.Security
{
    
    
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioServicio _usuarioServicio;
        public UsuarioController(IUsuarioServicio usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Usuario/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Usuario", typeof(Usuario))]
        [HttpGet]
        public async Task<IHttpActionResult> GetUsuarioListAsync()
        {
            try
            {
                var result = await Task.Run(() => _usuarioServicio.GetUsuarioListAsync());
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
        /// <param name="usuario"></param>
        /// <returns></returns>
        [Route("api/usuario/GetUsuarioById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los usuario", typeof(Usuario))]
        [HttpGet]
        public async Task<IHttpActionResult> GetusuarioByIdAsync(int idusuario)
        {
            try
            {
                var result = await Task.Run(() => _usuarioServicio.GetUsuarioByIdAsync(idusuario));
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
        /// <param name="usuario"></param>
        /// <returns></returns>
        [Route("api/usuario/InsertUsuario")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por  usuario", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertRolporUsuario(Usuario usuario)
        {
            try
            {
                await _usuarioServicio.InsertUsuario(usuario);
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
        /// <param name="usuario"></param>
        /// <returns></returns>
        [Route("api/usuario/UpdateUsuario")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por usuario", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateUsuario(Usuario usuario)
        {
            try
            {
                await _usuarioServicio.UpdateUsuario(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
