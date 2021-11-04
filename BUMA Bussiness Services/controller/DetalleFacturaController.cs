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
using buma.dominio.DTO.Negocio;
using buma.negocio.servicios.Interfaces;

namespace buma.business.services.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class DetalleFacturaController : Controller
    {
        private readonly IDetalleFacturaServicio _DetallefacturaServicio;
        public DetalleFacturaController(IConfiguration configuration, IDetalleFacturaServicio DetallefacturaServicio)
        {
            _DetallefacturaServicio = DetallefacturaServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Detallefactura>> GetDetallefacturaListAsync()
        {

            //object __DetallecompraServicio = null;
            return await _DetallefacturaServicio.GetDetallefacturaListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Detallefactura> GetDetallefacturaByIdAsync(int idDetallefactura)
        {
            var detallefactura = new Detallefactura();
            return detallefactura;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertDetallefactura(Detallefactura detallefactura)
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
        /// <param //name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task UpdateDetalleFactura(Detallefactura detallefactura)
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