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
    public class EmpresaPersistencia : IEmpresaPersistencia
    {
        public async Task<List<Empresa>> GetEmpresaListAsync()
        {
            var empresa = new List<Empresa>();
            return empresa;
        }
        public async Task<Empresa> GetEmpresaByIdAsync(int idEmpresa)
        {
            var empresa = new Empresa();
            return empresa;
        }
        public async Task InsertEmpresa(Empresa empresa)
        {
            empresa = new Empresa();
        }
        public async Task UpdateEmpresa(Empresa empresa)
        {
            empresa = new Empresa();
        }
    }
}
