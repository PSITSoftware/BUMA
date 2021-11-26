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
    public class RegimenPersistencia : IRegimenPersistencia
    {
        public async Task<List<Regimen>> GetRegimenListAsync()
        {
            var regimen = new List<Regimen>();
            return regimen;
        }
        public async Task<Regimen> GetRegimenByIdAsync(int idRegimen)
        {
            var regimen = new Regimen();
            return regimen;
        }
        public async Task InsertRegimen(Regimen regimen)
        {
            regimen = new Regimen();
        }
        public async Task UpdateRegimen(Regimen regimen)
        {
            regimen = new Regimen();
        }

    }
}
