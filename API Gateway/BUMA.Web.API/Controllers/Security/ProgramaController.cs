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
    public class ProgramaController : Controller
    {
        private readonly IProgramaServicio _programaServicio;
        public ProgramaController(IConfiguration configuration, IProgramaServicio programaServicio)
        {
            _programaServicio = programaServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Programa>> GetProgramaListAsync()
        {

            return await _programaServicio.GetProgramaListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Programa> GetProgramaByIdAsync(int idPrograma)
        {
            var programa = new Programa();
            return programa;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InserPrograma(Programa programa)
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
        public async Task UpdateProgrma(Programa programa)
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
