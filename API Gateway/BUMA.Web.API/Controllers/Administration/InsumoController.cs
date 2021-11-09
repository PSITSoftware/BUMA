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
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;

namespace BUMA.Web.API.Controllers.Administration
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]


    public class InsumoController : Controller


    {

        private readonly IInsumoServicio _insumoServicio;
        public InsumoController(IConfiguration configuration, IInsumoServicio insumoServicio)
            {
                _insumoServicio = insumoServicio;
            }


            /// <summary>
            /// Obtiene el listado de todos los Usuarios
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            public async Task<List<Insumo>> GetInsumoListAsync()
            {

                return await _insumoServicio.GetInsumoListAsync();
            }

            /// <summary>
            /// Obtiene los Usuarios por Identificador
            /// </summary>
            /// <param name="idUsuario"></param>
            /// <returns></returns>
            [HttpGet]
            public async Task<Insumo> GetInsumoByIdAsync(int idInsumo)
            {
                var insumo = new Insumo();
                return insumo;
            }

            /// <summary>
            /// Inserta la informaciòn del usuario
            /// </summary>
            /// <param //name="usuario"></param>
            /// <returns></returns>

            [HttpPost]
            public async Task InsertInsumo( Insumo insumo)
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
            public async Task UpdateInsumo(Insumo insumo)
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
