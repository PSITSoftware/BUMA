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
        public class FacturaController : ApiController
    {
        
        private readonly IFacturaServicio _facturaServicio;
        public FacturaController(IFacturaServicio facturaServicio)
        {
            _facturaServicio = facturaServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Factura/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de las facturas", typeof(Factura))]
        [HttpGet]
        public async Task<IHttpActionResult> GetFacturaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _facturaServicio.GetFacturaListAsync());
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
        /// <param name="idfactura"></param>
        /// <returns></returns>
        [Route("api/Factura/GetFacturaById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados  de facturas", typeof(Factura))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDetallefacturaByIdAsync(int idfactura)
        {
            try
            {
                var result = await Task.Run(() => _facturaServicio.GetFacturaByIdAsync(idfactura));
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
        /// <param name="factura"></param>
        /// <returns></returns>
        [Route("api/Factura/InsertFactura")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por  factura", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertFactura(Factura factura)
        {
            try
            {
                await _facturaServicio.InsertFactura(factura);
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
        /// <param name="factura"></param>
        /// <returns></returns>
        [Route("api/factura/UpdateFactura")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por las facturas", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateDetalleFacturas(Factura factura)
        {
            try
            {
                await _facturaServicio.UpdateFactura(factura);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
