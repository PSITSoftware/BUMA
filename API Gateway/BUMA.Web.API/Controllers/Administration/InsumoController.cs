// ==================================================================================
// Desarrollado Por	    : Edwin Andres FLOREZ
// Fecha de Creación	: 28/10/2021
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
// 0.1	28/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


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
   
    public class InsumoController : ApiController


    {

        private readonly IInsumoServicio _insumoServicio;
        public InsumoController(IInsumoServicio insumoServicio)
            {
                _insumoServicio = insumoServicio;
            }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Insumo/GetInsumoList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de preguntas personalizadas", typeof(Insumo))]
        [HttpGet]
        public async Task<IHttpActionResult> GetCajaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _insumoServicio.GetInsumoListAsync());
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
        /// <param name="idInsumo"></param>
        /// <returns></returns>
        [Route("api/Insumo/GetInsumoById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de preguntas personalizadas", typeof(Insumo))]
        [HttpGet]
        public async Task<IHttpActionResult> GetCajaByIdAsync(int idInsumo)
        {
            try
            {
                var result = await Task.Run(() => _insumoServicio.GetInsumoByIdAsync(idInsumo));
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
        /// <param name="caja"></param>
        /// <returns></returns>
        [Route("api/insumo/InsertInsumo")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por guardado de Preguntas Personalizadas", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertInsumo(Insumo insumo)
        {
            try
            {
                await _insumoServicio.InsertInsumo(insumo);
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
        /// <param name="insumo"></param>
        /// <returns></returns>
        [Route("api/Insumo/UpdateInsumo")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por insumos actualizados", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateInsumo(Insumo insumo)
        {
            try
            {
                await _insumoServicio.UpdateInsumo(insumo);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
    }
