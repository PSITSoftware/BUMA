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
    
    public class TransaccionController : ApiController
    {
        private readonly ITransaccionServicio _transaccionServicio;
        public TransaccionController(ITransaccionServicio transaccionServicio)
        {
            _transaccionServicio = transaccionServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Transaccion/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de Transacciones", typeof(Trasaccion))]
        [HttpGet]
        public async Task<IHttpActionResult> GetTransaccionListAsync()
        {
            try
            {
                var result = await Task.Run(() => _transaccionServicio.GetTransaccionListAsync());
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
        /// <param name="idtransaccion"></param>
        /// <returns></returns>
        [Route("api/Transaccion/GetTransaccionById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de transacciones", typeof(Trasaccion))]
        [HttpGet]
        public async Task<IHttpActionResult> GetSucursalByIdAsync(int idTransaccion)
        {
            try
            {
                var result = await Task.Run(() => _transaccionServicio.GetTransaccionByIdAsync(idTransaccion));
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
        /// <param name="transaccion"></param>
        /// <returns></returns>
        [Route("api/transaccion/InsertTransaccion")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por transaccion", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertTransaccion(Trasaccion trasaccion)
        {
            try
            {
                await _transaccionServicio.InsertTrasaccion(trasaccion);
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
        /// <param name="transaccion"></param>
        /// <returns></returns>
        [Route("api/transaccion/UpdateTransaccion")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Transaccion", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateTransaccion(Trasaccion trasaccion)
        {
            try
            {
                await _transaccionServicio.UpdateTrasaccion(trasaccion);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
