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

    public class DetalleCompraController : Controller
    {
        private readonly IDetalleCompraServicio _DetallecompraServicio;
        public DetalleCompraController(IConfiguration configuration, IDetalleCompraServicio DetallecompraServicio)
        {
            _DetallecompraServicio = DetallecompraServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Detallecompra>> GetDetalleCompraListAsync()
        {

            //object __DetallecompraServicio = null;
            return await _DetallecompraServicio.GetDetallecompraListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Detallecompra> GetDetallecompraByIdAsync(int idDetallecompra)
        {
            var detalleCompra = new Detallecompra();
            return detalleCompra;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertDetallecompra(Detallecompra detallecompra)
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
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task UpdateDetallecompra(Detallecompra detallecompra)
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