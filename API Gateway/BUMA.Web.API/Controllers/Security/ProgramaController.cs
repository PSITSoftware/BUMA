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
 
    public class ProgramaController : ApiController
    {
        private readonly IProgramaServicio _programaServicio;
        public ProgramaController(IProgramaServicio programaServicio)
        {
            _programaServicio = programaServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Programa/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los programas", typeof(Programa))]
        [HttpGet]
        public async Task<IHttpActionResult> GetProgramaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _programaServicio.GetProgramaListAsync());
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
        /// <param name="idprograma"></param>
        /// <returns></returns>
        [Route("api/Programa/GetProgramaById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los programas", typeof(Programa))]
        [HttpGet]
        public async Task<IHttpActionResult> GetprogramaByIdAsync(int idprograma)
        {
            try
            {
                var result = await Task.Run(() => _programaServicio.GetProgramaByIdAsync(idprograma));
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
        /// <param name="programa"></param>
        /// <returns></returns>
        [Route("api/Programa/InsertPrograma")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por programa", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertPrograma(Programa programa)
        {
            try
            {
                await _programaServicio.InsertPrograma(programa);
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
        /// <param name="programa"></param>
        /// <returns></returns>
        [Route("api/Programa/UpdatePrograma")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por programa", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdatePrograma(Programa programa)
        {
            try
            {
                await _programaServicio.UpdatePrograma(programa);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
