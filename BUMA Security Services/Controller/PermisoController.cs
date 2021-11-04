using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Security.Policy;
using System.Data;
using buma.dominio.DTO.Seguridad;
using buma.security.servicios.Interfaces;

namespace buma.security.services.Controllers
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
