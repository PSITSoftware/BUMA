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
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;


namespace BUMA.Web.API.Controllers.Administration
{
    public class ProvedorController : ApiController
    {
        private readonly IProvedorServicio _provedorServicio;
        public ProvedorController(IProvedorServicio provedorServicio)
        {
            _provedorServicio = provedorServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Provedor/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de provedores", typeof(Provedor))]
        [HttpGet]
        public async Task<IHttpActionResult> GetProvedorListAsync()
        {
            try
            {
                var result = await Task.Run(() => _provedorServicio.GetProvedorListAsync());
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
        /// <param name="idprovedor"></param>
        /// <returns></returns>
        [Route("api/Provedor/GetProvedorById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de provedor", typeof(Provedor))]
        [HttpGet]
        public async Task<IHttpActionResult> GetProvedorByIdAsync(int idProvedor)
        {
            try
            {
                var result = await Task.Run(() => _provedorServicio.GetProvedorByIdAsync(idProvedor));
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
        /// <param name="producto"></param>
        /// <returns></returns>
        [Route("api/provedor/InsertProvedor")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por provedor", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertProvedor(Provedor provedor)
        {
            try
            {
                await _provedorServicio.InsertProvedor(provedor);
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
        /// <param name="provedor"></param>
        /// <returns></returns>
        [Route("api/Provedor/UpdateProvedor")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Producto", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateProvedor(Provedor provedor)
        {
            try
            {
                await _provedorServicio.UpdateProvedor(provedor);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
