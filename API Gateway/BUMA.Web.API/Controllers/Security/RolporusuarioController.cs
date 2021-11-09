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
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Security;
using BUMA.Security.Services.Interfaces;

namespace BUMA.Web.API.Controllers.Security
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]

    public class RolporusuarioController : Controller
    {
        private readonly IRolporusuarioServicio _rolporusuarioServicio;
        public RolporusuarioController(IConfiguration configuration, IRolporusuarioServicio RolporusuarioServicio)
        {
            _rolporusuarioServicio = RolporusuarioServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<RolxUsuario>> GetRolporUsuarioListAsync()
        {
            return await _rolporusuarioServicio.GetRolporUsuarioListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<RolxUsuario> GetRolporusuarioByIdAsync(int idRolporusuario)
        {
            var rolporusuario = new RolxUsuario();
            return rolporusuario;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertUsuario(RolxUsuario rolporusuario)
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
        public async Task UpdateRolporUsuario(RolxUsuario rolporusuario)
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
