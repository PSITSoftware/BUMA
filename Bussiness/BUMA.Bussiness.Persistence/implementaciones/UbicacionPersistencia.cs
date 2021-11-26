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
    public class UbicacionPersistencia
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
