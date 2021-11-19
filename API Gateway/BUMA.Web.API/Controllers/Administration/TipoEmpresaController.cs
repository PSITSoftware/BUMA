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
    
    public class TipoEmpresaController : ApiController
    {
        private readonly ITipoEmpresaServicio _tipoempresaServicio;
        public TipoEmpresaController(ITipoEmpresaServicio tipoempresaServicio)
        {
            _tipoempresaServicio = tipoempresaServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/TipoEmpresa/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de tipos de empresa", typeof(TipoEmpresa))]
        [HttpGet]
        public async Task<IHttpActionResult> GetTipoEmpresaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _tipoempresaServicio.GetTipoEmpresaListAsync());
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
        /// <param name="idtipoempresa"></param>
        /// <returns></returns>
        [Route("api/Tipoempresa/GetTipoempresaById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los tipos de empresa", typeof(TipoEmpresa))]
        [HttpGet]
        public async Task<IHttpActionResult> GetTipoEmpresaByIdAsync(int idTipoempresa)
        {
            try
            {
                var result = await Task.Run(() => _tipoempresaServicio.GetTipoEmpresaByIdAsync(idTipoempresa));
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
        /// <param name="tipoempresa"></param>
        /// <returns></returns>
        [Route("api/tipoempresa/InsertTipoempresa")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por tipo de empresa", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertTipoEmpresa(TipoEmpresa tipoempresa)
        {
            try
            {
                await _tipoempresaServicio.InsertTipoEmpresa(tipoempresa);
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
        /// <param name="tipoempresa"></param>
        /// <returns></returns>
        [Route("api/TipoEmpresa/UpdateTipoEmpresa")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por tipo de empresa", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateTipoempresa(TipoEmpresa tipoempresa)
        {
            try
            {
                await _tipoempresaServicio.UpdateTipoEmpresa(tipoempresa);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
