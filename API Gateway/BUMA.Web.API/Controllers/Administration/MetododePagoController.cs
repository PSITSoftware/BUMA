// ==================================================================================
// Desarrollado Por	    : Edwin Andres FLOREZ
// Fecha de Creación	: 29/10/2021
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
// 0.1	29/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


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
    public class MetododePagoController : Controller
    {
        private readonly IMetodoPagoServicio _metodopagoServicio;
        public MetododePagoController(IConfiguration configuration, IMetodoPagoServicio metododepagoServicio)
        {
            _metodopagoServicio = metododepagoServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Metodopago>> GetMetodoPagoListAsync()
        {

            return await _metodopagoServicio.GetMetodoPagoListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Metodopago> GetMetodoPagoByIdAsync(int idmetodopago)
        {
            var metodopago = new Metodopago();
            return metodopago;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertMetodoPago(Metodopago metodopago)
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
        public async Task UpdateMetodoPago(Metodopago metodopago)
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
