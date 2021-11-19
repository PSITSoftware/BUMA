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
// 0.1	25/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Administration
{
    
    public class ControlController : ApiController
    {
        private readonly IControlServicio _controlServicio;
        public ControlController(IControlServicio controlServicio)
        {
            _controlServicio = controlServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los controles
        /// </summary>
        /// <returns></returns>
        [Route("api/Control/GetControlList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de controles", typeof(Control))]
        [HttpGet]
       
        public async Task<IHttpActionResult> GetControlListAsync()
        {
            try
            {
                var result = await Task.Run(() => _controlServicio.GetControlListAsync());
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
            
        }

        /// <summary>
        /// Obtiene los Controles por Identificador
        /// </summary>
        /// <param name="idControl"></param>
        /// <returns></returns>
        [Route("api/Control/GetControlById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de controles por identificador", typeof(Control))]
        
        public async Task<IHttpActionResult> GetControlByIdAsync(int idControl)
        {
            try
            {
                var result = await Task.Run(() => _controlServicio.GetControlByIdAsync(idControl));
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
           
        }

        /// <summary>
        /// Inserta la informaciòn del control
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        [Route("api/Control/InsertControl")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por guardado de Controles", typeof(HttpResponseMessage))]
       
        [HttpPost]
        public async Task<IHttpActionResult> InsertControl(Control control)
        {
            try
            {
                await _controlServicio.InsertControl(control);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Actualiza la informaciòn del control
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        [Route("api/Control/UpdateControl")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por guardado de Controles", typeof(HttpResponseMessage))]
      
        [HttpPost]
        public async Task<IHttpActionResult> UpdateControl(Control control)
        {
            try
            {
                await _controlServicio.UpdateControl(control);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
