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
