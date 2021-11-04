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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Negocio;
using buma.negocio.servicios.Interfaces;

namespace buma.negocio.servicios.Inplementaciones
{
    public class SubUbicacionServicio : ISubUbicacionServicio
    {
        public async Task<List<Sububicacion>> GetSubUbicacionListAsync()
        {
            var sububicacion = new List<Sububicacion>();
            return sububicacion;
        }

        public async Task<Sububicacion> GetSubUbicacionByIdAsync(int idSubUbicacion)
        {
            var sububicacion = new Sububicacion();
            return sububicacion;
        }
        public async Task InsertSubUbicacion(Sububicacion sububicacion)
        {
            sububicacion = new Sububicacion();

        }
        public async Task UpdateSubUbicacion(Sububicacion sububicacion)
        {
            sububicacion = new Sububicacion();
        }
    }
}
