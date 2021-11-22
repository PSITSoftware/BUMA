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
