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
    public class SucursalPersistencia : ISucursalPersistencia
    {
        
            public async Task<List<Sucursal>> GetSucursalListAsync()
            {
                var sucursal = new List<Sucursal>();
                return sucursal;
            }
            public async Task<Sucursal> GetSucursalByIdAsync(int idSucursal)
            {
                var sucursal = new Sucursal();
                return sucursal;
            }
            public async Task InsertSucursal(Sucursal sucursal)
            {
            sucursal = new Sucursal();
            }
            public async Task UpdateSucursal(Sucursal sucursal)
            {
            sucursal = new Sucursal();
            }
    }
}
