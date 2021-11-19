// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 28/10/2021
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
// 0.1	28/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


using System;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Bussiness
{
    public class UbicacionController : ApiController
    {
        private readonly IUbicacionServicio _UbicacionServicio;
        public UbicacionController(IUbicacionServicio ubicacionServicio)
        {
            _UbicacionServicio = ubicacionServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Ubicacion/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de las uicaciones", typeof(Ubicacion))]
        [HttpGet]
        public async Task<IHttpActionResult> GetUbicacionListAsync()
        {
            try
            {
                var result = await Task.Run(() => _UbicacionServicio.GetUbicacionListAsync());
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
        /// <param name="idubicacion"></param>
        /// <returns></returns>
        [Route("api/Ubicacion/GetUbicacionById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados  de ubicacion", typeof(Ubicacion))]
        [HttpGet]
        public async Task<IHttpActionResult> GetubicacionByIdAsync(int idubicacion)
        {
            try
            {
                var result = await Task.Run(() => _UbicacionServicio.GetUbicacionByIdAsync(idubicacion));
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
        /// <param name="ubicacion"></param>
        /// <returns></returns>
        [Route("api/Ubicacion/InsertUbicacion")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por ubicacion", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertUbicacion(Ubicacion ubicacion)
        {
            try
            {
                await _UbicacionServicio.InsertUbicacion(ubicacion);
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
        /// <param name="ubicacion"></param>
        /// <returns></returns>
        [Route("api/Ubicacion/UpdateUbicacion")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por la ubicacion", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateDetalleFacturas(Ubicacion ubicacion)
        {
            try
            {
                await _UbicacionServicio.UpdateUbicacion(ubicacion);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
