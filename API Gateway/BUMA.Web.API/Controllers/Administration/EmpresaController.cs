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


using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using Swashbuckle.Swagger.Annotations;

namespace BUMA.Web.API.Controllers.Administration
{

    public class EmpresaController : ApiController
    {

        private readonly IEmpresaServicio _empresaServicio;
        public EmpresaController( IEmpresaServicio empresaServicio)
        {
            _empresaServicio = empresaServicio;
        }


        /// <summary>
        /// Obtiene el listado de todos los Usuarios
        /// </summary>
        /// <returns></returns>
        [Route("api/Empresa/GetEmpresaList")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de empresas", typeof(Empresa))]
       
        [HttpGet]
        public async Task<IHttpActionResult> GetEmpresaListAsync()
        {

            try
            {
                var result = await Task.Run(() => _empresaServicio.GetEmpresaListAsync());
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Obtiene los Usuarios por Identificador
        /// </summary>
        /// <param name="idempresa"></param>
        /// <returns></returns>
        [Route("api/Empresa/GetEmpresaById")]
        [SwaggerResponse(HttpStatusCode.OK, "Retorna los listados de Empresas", typeof(Empresa))]
        [HttpGet]
        public async Task<IHttpActionResult> GetEmpresaByIdAsync(int idEmpresa)
        {
            try
            {
                var result = await Task.Run(() => _empresaServicio.GetEmpresaByIdAsync(idEmpresa));
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }

        /// <summary>
        /// Inserta la informaciòn de la empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>

        [Route("api/Empresa/InsertEmpresa")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por guardado empresa", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> InsertEmpresa(Empresa empresa)
        {
            try
            {
                await _empresaServicio.InsertEmpresa(empresa);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }


        /// <summary>
        /// Actualiza la informaciòn del usuario
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns></returns>
        [Route("api/Empresa/Empresa")]
        [SwaggerResponse(HttpStatusCode.OK, "Informacion devuelta por guardado de Preguntas Personalizadas", typeof(HttpResponseMessage))]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateEmpresa(Empresa empresa)
        {
            try
            {
                await _empresaServicio.UpdateEmpresa(empresa);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
            }
        }
    }
}
