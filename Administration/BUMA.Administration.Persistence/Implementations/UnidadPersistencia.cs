// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 22/11/2021
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
// 0.1	22/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class UnidadPersistencia : IUnidadPersistencia
    {
        public async Task<List<Unidad>> GetUnidadListAsync()
        {
            var unidad = new List<Unidad>();
            return unidad;
        }
        public async Task<Unidad> GetUnidadByIdAsync(int idUnidad)
        {
            var unidad = new Unidad();
            return unidad;
        }
        public async Task InsertUnidad(Unidad unidad)
        {
            unidad = new Unidad();
        }
        public async Task UpdateUnidad(Unidad unidad)
        {
            unidad = new Unidad();
        }
    }
}
