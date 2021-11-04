// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 25/10/2021
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
// 0.1	25/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


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
using buma.securiy.servicios.Interfaces;
namespace buma.security.services.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class ModuloController : Controller
    {
        private readonly IModuloServicio _moduloServicio;
        public ModuloController(IConfiguration configuration, IModuloServicio moduloServicio)
        {
            _moduloServicio = moduloServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Modulos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Modulo>> GetModuloListAsync()
        {

            return await _moduloServicio.GetModuloListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idmodulo"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Modulo> GetModuloByIdAsync(int idModulo)
        {
            var modulo = new Modulo();
            return modulo;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="modulo"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertModulo(Modulo modulo)
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
        /// <param name="modulo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task UpdateModulo(Modulo modulo)
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
