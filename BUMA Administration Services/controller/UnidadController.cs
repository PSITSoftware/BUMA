﻿// ==================================================================================
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
using buma.dominio.DTO.Administracion;
using Buma.Administracion.servicios.Interfaces;

namespace buma.administration.services.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class UnidadController : Controller
    {
        private readonly IUnidadServicio _unidadServicio;
        public UnidadController(IConfiguration configuration, IUnidadServicio unidadServicio)
        {
            _unidadServicio = unidadServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Unidad>> GetUnidadListAsync()
        {

            return await _unidadServicio.GetUnidadListAsync();
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Unidad> GetUnidadByIdAsync(int idUnidad)
        {
            var unidad = new Unidad();
            return unidad;
        }

        /// <summary>
        /// Inserta la informaciòn del usuario
        /// </summary>
        /// <param //name="usuario"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task InsertUnidad(Unidad unidad)
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
        public async Task UpdateUnidad(Unidad unidad)
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
