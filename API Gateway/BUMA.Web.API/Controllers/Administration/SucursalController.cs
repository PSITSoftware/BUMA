// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 29/10/2021
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
// 0.1	29/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


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
    
    public class SucursalController : ApiController
    {
        private readonly ISucursalServicio _sucursalServicio;
        public SucursalController(ISucursalServicio sucursalServicio)
        {
            _sucursalServicio = sucursalServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Sucursal/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de sucursal", typeof(Sucursal))]
        [HttpGet]
        public async Task<IHttpActionResult> GetSucrsalListAsync()
        {
            try
            {
                var result = await Task.Run(() => _sucursalServicio.GetSucursalListAsync());
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
        /// <param name="idsucursal"></param>
        /// <returns></returns>
        [Route("api/Sucursal/GetSucursalById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de sucursales", typeof(Sucursal))]
        [HttpGet]
        public async Task<IHttpActionResult> GetSucursalByIdAsync(int idSucursal)
        {
            try
            {
                var result = await Task.Run(() => _sucursalServicio.GetSucursalByIdAsync(idSucursal));
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
        /// <param name="regimen"></param>
        /// <returns></returns>
        [Route("api/sucursal/InsertSucursal")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por sucursal", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertSucursal(Sucursal sucursal)
        {
            try
            {
                await _sucursalServicio.InsertSucursal(sucursal);
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
        /// <param name="sucursal"></param>
        /// <returns></returns>
        [Route("api/Sucursal/UpdateSucursal")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Sucursal", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateSucursal(Sucursal sucursal)
        {
            try
            {
                await _sucursalServicio.UpdateSucursal(sucursal);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
