// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 27/10/2021
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
// 0.1	27/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

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
    

    public class ClienteController : ApiController
    {
        private readonly IClienteServicio _clienteServicio;
        public ClienteController(IClienteServicio clienteServicio)
        {
            _clienteServicio = clienteServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Cliente/GetList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de Clientes", typeof(Cliente))]
        [HttpGet]
        public async Task<IHttpActionResult> GetClienteListAsync()
        {
            try
            {
                var result = await Task.Run(() => _clienteServicio.GetClienteListAsync());
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
        /// <param name="idcliente"></param>
        /// <returns></returns>
        [Route("api/Cliente/GetClienteById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de clientes", typeof(Cliente))]
        [HttpGet]
        public async Task<IHttpActionResult> GetClienteByIdAsync(int idCliente)
        {
            try
            {
                var result = await Task.Run(() => _clienteServicio.GetClienteByIdAsync(idCliente));
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
        /// <param name="cliente"></param>
        /// <returns></returns>
        [Route("api/Cliente/InsertCliente")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por Clientes", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertCliente(Cliente cliente)
        {
            try
            {
                await _clienteServicio.InsertCliente(cliente);
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
        /// <param name="cliente"></param>
        /// <returns></returns>
        [Route("api/cliente/UpdateCliente")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por los Clientes", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateCliente(Cliente cliente)
        {
            try
            {
                await _clienteServicio.UpdateCliente(cliente);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
