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
    public class ProgramarolController : Controller
    {
        private readonly IProgramarolServicio _programarolServicio;
        public ProgramarolController(IConfiguration configuration, IProgramarolServicio programarolServicio)
        {
            _programarolServicio = programarolServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Programarol>> GetProgramarolListAsync()
        {

            return await _programarolServicio.GetProgramarolListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idprogramarol"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Programarol> GetProgramarolByIdAsync(int idProgramarol)
        {
            var programarol = new Programarol();
            return programarol;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertProgramarol(Programarol programarol)
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
        public async Task UpdateProgramarol(Programarol programarol)
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
