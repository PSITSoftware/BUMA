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
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;

namespace BUMA.Web.API.Controllers.Bussiness
{
    public class UbicacionController : Controller
    {
        private readonly IUbicacionServicio _UbicacionServicio;
        public UbicacionController(IConfiguration configuration, IUbicacionServicio ubicacionServicio)
        {
            _UbicacionServicio = ubicacionServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Ubicacion>> GetUbicacionListAsync()
        {

            //object __DetallecompraServicio = null;
            return await _UbicacionServicio.GetUbicacionListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Ubicacion> GetUbicacionByIdAsync(int idUbicacion)
        {
            var ubicacion = new Ubicacion();
            return ubicacion;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertUbicacion(Ubicacion ubicacion)
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
        public async Task UpdateUbicacion(Ubicacion ubicacion)
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
