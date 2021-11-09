// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 30/10/2021
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
// 0.1	30/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

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
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;

namespace BUMA.Web.API.Controllers.Administration
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class TipoDocumentoController : Controller
    {
        private readonly ITipoDocumentoServicio _tipodocumentoServicio;
        public TipoDocumentoController(IConfiguration configuration, ITipoDocumentoServicio tipodocumentoServicio)
        {
            _tipodocumentoServicio = tipodocumentoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Tipodocumento>> GetTipodocumentoservicioListAsync()
        {

            return await _tipodocumentoServicio.GetTipodocumentoListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Tipodocumento> GetTipodocumentoservicioByIdAsync(int idTipoDocumento)
        {
            var tipodocumento = new Tipodocumento();
            return tipodocumento;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param //name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertTipodocumento(Tipodocumento tipodocumento)
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
        public async Task UpdateTipodocumento(Tipodocumento tipodocumento)
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
