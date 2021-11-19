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

    public class ProgramarolController : ApiController
    {
        private readonly IProgramarolServicio _programarolServicio;
        public ProgramarolController(IProgramarolServicio programarolServicio)
        {
            _programarolServicio = programarolServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Programarol/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los programarol", typeof(Programarol))]
        [HttpGet]
        public async Task<IHttpActionResult> GetProgramarolListAsync()
        {
            try
            {
                var result = await Task.Run(() => _programarolServicio.GetProgramarolListAsync());
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
        /// <param name="idprogramarol"></param>
        /// <returns></returns>
        [Route("api/Programarol/GetProgramarolById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los programarol", typeof(Programarol))]
        [HttpGet]
        public async Task<IHttpActionResult> GetProgramarolByIdAsync(int idprogramarol)
        {
            try
            {
                var result = await Task.Run(() => _programarolServicio.GetProgramarolByIdAsync(idprogramarol));
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
        /// <param name="programarol"></param>
        /// <returns></returns>
        [Route("api/Programarol/InsertProgramarol")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por programarol", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertProgramarol(Programarol programarol)
        {
            try
            {
                await _programarolServicio.InsertProgramarol(programarol);
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
        /// <param name="programarol"></param>
        /// <returns></returns>
        [Route("api/Programarol/UpdateProgramarol")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por programarol", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdatePermisos(Programarol programarol)
        {
            try
            {
                await _programarolServicio.UpdateProgramarol(programarol);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
