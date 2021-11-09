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
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;

namespace BUMA.Web.API.Controllers.Bussiness
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class DetallePedidoController : Controller
    {
        private readonly IDetallePedidoServicio _DetallepedidoServicio;
        public DetallePedidoController(IConfiguration configuration, IDetallePedidoServicio DetallepedidoServicio)
        {
            _DetallepedidoServicio = DetallepedidoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Detallepedido>> GetDetallepedidoListAsync()
        {

            //object __DetallecompraServicio = null;
            return await _DetallepedidoServicio.GetDetallepedidoListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Detallepedido> GetDetallepedidoByIdAsync(int idDetallepedido)
        {
            var detallepedido = new Detallepedido();
            return detallepedido;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertDetallepedido(Detallepedido detallepedido)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Actualiza la informaciòn del usuario
        /// </summary>
        /// <param //name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task UpdateDetallePedido(Detallepedido detallepedido)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}