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
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using System.Net.Http;

namespace BUMA.Web.API.Controllers.Bussiness
{

    public class DetalleFacturaController : ApiController
    {
        private readonly IDetalleFacturaServicio _detallefacturaServicio;
        public DetalleFacturaController( IDetalleFacturaServicio DetallefacturaServicio)
        {
            _detallefacturaServicio = DetallefacturaServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/DetalleFactura/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los Detalles de factura", typeof(Detallefactura))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDetalleFacturaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _detallefacturaServicio.GetDetallefacturaListAsync());
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
        /// <param name="iddetallefactura"></param>
        /// <returns></returns>
        [Route("api/DetalleFactura/GetDetalleFacturaById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de detalles de factura", typeof(Detallefactura))]
        [HttpGet]
        public async Task<IHttpActionResult> GetDetallefacturaByIdAsync(int idDetallefactura)
        {
            try
            {
                var result = await Task.Run(() => _detallefacturaServicio.GetDetallefacturaByIdAsync(idDetallefactura));
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
        /// <param name="detallefactura"></param>
        /// <returns></returns>
        [Route("api/DetalleFactura/InsertDetalleFactura")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por detalles de factura", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertDetalleFactura(Detallefactura detallefactura)
        {
            try
            {
                await _detallefacturaServicio.InsertDetallefactura(detallefactura);
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
        /// <param name="detallefactura"></param>
        /// <returns></returns>
        [Route("api/detallesfactura/UpdateDetalleFactura")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por los detalles de facturas", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateDetalleFacturas(Detallefactura detallefactura)
        {
            try
            {
                await _detallefacturaServicio.UpdateDetallefactura(detallefactura);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}