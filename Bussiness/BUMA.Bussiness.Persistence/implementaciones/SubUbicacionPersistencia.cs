// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 23/11/2021
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
// 0.1	23/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class SubUbicacionPersistencia : ISubUbicacionPersistencia
    {
        public async Task<List<Sububicacion>> GetSububicacionListAsync()
        {
            var sububicacion = new List<Sububicacion>();
            return sububicacion;
        }
        public async Task<Sububicacion> GetSububicacionByIdAsync(int idSububicacion)
        {
            var Sububicacion = new Sububicacion();
            return Sububicacion;
        }
        public async Task InsertSububicacion(Sububicacion sububicacion)
        {
            sububicacion = new Sububicacion();
        }
        public async Task UpdateSububicacion(Sububicacion sububicacion)
        {
            sububicacion = new Sububicacion();
        }
    }
}
