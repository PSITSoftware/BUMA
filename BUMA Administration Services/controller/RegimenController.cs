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

    public class RegimenController : Controller
    {
        private readonly IRegimenServicio _regimenServicio;
        public RegimenController(IConfiguration configuration, IRegimenServicio regimenServicio)
        {
            _regimenServicio = regimenServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Regimen>> GetRegimenListAsync()
        {

            return await _regimenServicio.GetRegimenListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Regimen> GetRegimenByIdAsync(int idRegimen)
        {
            var regimen = new Regimen();
            return regimen;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param //name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertRegimen(Regimen regimen)
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
        /// <param //name="regimen"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task UpdateRegimen(Regimen regimen)
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
