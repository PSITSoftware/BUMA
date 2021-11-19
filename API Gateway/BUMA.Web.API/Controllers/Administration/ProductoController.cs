// ==================================================================================
// Desarrollado Por	    : Edwin Andres FLOREZ
// Fecha de Creación	: 29/10/2021
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
    public class ProductoController : ApiController
    {
        private readonly IProductoServicio _productoServicio;
        public ProductoController(IProductoServicio productoServicio)
        {
            _productoServicio = productoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Producto/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de productos", typeof(producto))]
        [HttpGet]
        public async Task<IHttpActionResult> GetProductoListAsync()
        {
            try
            {
                var result = await Task.Run(() => _productoServicio.GetProductoListAsync());
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
        /// <param name="idproducto"></param>
        /// <returns></returns>
        [Route("api/Producto/GetProductoById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de productos", typeof(producto))]
        [HttpGet]
        public async Task<IHttpActionResult> GetProductoByIdAsync(int idProducto)
        {
            try
            {
                var result = await Task.Run(() => _productoServicio.GetProductoByIdAsync(idProducto));
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
        /// <param name="producto"></param>
        /// <returns></returns>
        [Route("api/producto/InsertProducto")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por producto", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertProducto(producto producto)
        {
            try
            {
                await _productoServicio.InsertProducto(producto);
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
        /// <param name="producto"></param>
        /// <returns></returns>
        [Route("api/Producto/UpdateProducto")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Producto", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateProducto(producto producto)
        {
            try
            {
                await _productoServicio.UpdateProducto(producto);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
