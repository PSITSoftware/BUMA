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
     public class UbicacionServicio :IUbicacionServicio 
    {
        public async Task<List<Ubicacion>> GetUbicacionListAsync()
        {
            var ubicacion = new List<Ubicacion>();
            return ubicacion;
        }

        public async Task<Ubicacion> GetUbicacionByIdAsync(int idUbicacion)
        {
            var ubicacion = new Ubicacion();
            return ubicacion;
        }
        public async Task InsertUbicacion(Ubicacion ubicacion)
        {
            ubicacion = new Ubicacion();

        }
        public async Task UpdateUbicacion(Ubicacion ubicacion)
        {
            ubicacion = new Ubicacion();
        }
    }
}
