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

    public class ComprasController : Controller
    {
        private readonly IComprasServicio _comprasServicio;
        public ComprasController(IConfiguration configuration, IComprasServicio comprasServicio)
        {
            _comprasServicio = comprasServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Compras>> GetComprasListAsync()
        {

            return await _comprasServicio.GetComprasListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Compras> GetComprasByIdAsync(int idCompras)
        {
            var compras = new Compras();
            return compras;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertCompras(Compras compras)
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
        public async Task UpdateCompras(Compras compras)
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
