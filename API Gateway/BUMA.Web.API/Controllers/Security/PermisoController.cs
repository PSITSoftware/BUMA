using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Security;
using BUMA.Security.Services.Interfaces;

namespace BUMA.Web.API.Controllers.Security
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class PermisoController : Controller
    {
    private readonly IPermisoServicio _permisosServicio; 
    public PermisoController(IConfiguration configuration, IPermisoServicio permisiosServicio)
    {
        _permisosServicio = permisiosServicio;
    }

        /// <summary>
        /// Obtiene el listado de todos los Permisos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Permiso>> GetPermisosListAsync()
        {

            return await _permisosServicio.GetPermisosListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Permiso> GetPermisosByIdAsync(int idPermisos)
        {
            var permisos = new Permiso();
            return permisos;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertPermisos(Permiso permiso)
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
        public async Task UpdateUsuario(Permiso permiso)
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
