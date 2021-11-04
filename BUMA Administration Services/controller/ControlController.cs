// ==================================================================================
// Desarrollado Por	    : Edwin Andres FLOREZ
// Fecha de Creación	: 28/10/2021
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
using buma.dominio.DTO.Administracion;
using Buma.Administracion.servicios.Interfaces;

namespace buma.administration.services.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class ControlController : Controller
    {
        private readonly IControlServicio _controlServicio;
        public ControlController(IConfiguration configuration, IControlServicio controlServicio)
        {
            _controlServicio = controlServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Control>> GetControlListAsync()
        {

            return await _controlServicio.GetControlListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Control> GetControlByIdAsync(int idControl)
        {
            var control = new Control();
            return control;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertControl(Control control)
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
        public async Task UpdateControl(Control control)
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
