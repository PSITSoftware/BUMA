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
   
    public class InventarioController: ApiController
    {
        private readonly IInventarioServicio _InventarioServicio;
        public InventarioController(IInventarioServicio inventarioServicio)
        {
            _InventarioServicio = inventarioServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Inventario/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de los inventarios", typeof(Inventario))]
        [HttpGet]
        public async Task<IHttpActionResult> GetFacturaListAsync()
        {
            try
            {
                var result = await Task.Run(() => _InventarioServicio.GetInventarioListAsync());
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
        /// <param name="idinventario"></param>
        /// <returns></returns>
        [Route("api/Inventario/GetInventarioById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados  de inventarios", typeof(Inventario))]
        [HttpGet]
        public async Task<IHttpActionResult> GetinventarioByIdAsync(int idinventario)
        {
            try
            {
                var result = await Task.Run(() => _InventarioServicio.GetInventarioByIdAsync(idinventario));
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
        /// <param name="inventario"></param>
        /// <returns></returns>
        [Route("api/Inventario/InsertInventario")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por  inventario", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertInventario(Inventario inventario)
        {
            try
            {
                await _InventarioServicio.InsertInventario(inventario);
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
        [Route("api/Inventario/UpdateInventario")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por las facturas", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateDetalleFacturas(Inventario inventario)
        {
            try
            {
                await _InventarioServicio.UpdateInventario(inventario);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
