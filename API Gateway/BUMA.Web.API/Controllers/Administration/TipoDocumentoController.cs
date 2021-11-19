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

    public class TipoDocumentoController : ApiController
    {
        private readonly ITipoDocumentoServicio _tipodocumentoServicio;
        public TipoDocumentoController(ITipoDocumentoServicio tipodocumentoServicio)
        {
            _tipodocumentoServicio = tipodocumentoServicio;
        }


        [Route("api/Tipodocumentos/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de tipodocumentos", typeof(Tipodocumento))]
        [HttpGet]
        public async Task<IHttpActionResult> GetTipodocumentosListAsync()
        {
            try
            {
                var result = await Task.Run(() => _tipodocumentoServicio.GetTipodocumentoListAsync());
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
        /// <param name="idtipodocumentos"></param>
        /// <returns></returns>
        [Route("api/Tipodocumentos/GetTipodocumentosById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los tipos de documentos", typeof(Tipodocumento))]
        [HttpGet]
        public async Task<IHttpActionResult> GetTipodocumentosByIdAsync(int idTipodocumentos)
        {
            try
            {
                var result = await Task.Run(() => _tipodocumentoServicio.GetTipodocumentoByIdAsync(idTipodocumentos));
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
        /// <param name="tipodocumento"></param>
        /// <returns></returns>
        [Route("api/tipodocumento/InsertTipodocumento")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por tipo de documento", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertTipodocumento(Tipodocumento tipodocumento)
        {
            try
            {
                await _tipodocumentoServicio.InsertTipodocumento(tipodocumento);
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
        /// <param name="tipodocumento"></param>
        /// <returns></returns>
        [Route("api/TipoDocumento/UpdateTipoDocumento")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por tipo de documento", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateTipodocumento(Tipodocumento tipodocumento)
        {
            try
            {
                await _tipodocumentoServicio.UpdateTipodocumento(tipodocumento);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
