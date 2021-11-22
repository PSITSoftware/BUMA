using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IEmpresaPersistencia
    {

        Task<List<Empresa>> GetEmpresaListAsync();
        Task<Empresa> GetEmpresaByIdAsync(int idEmpresa);
        Task InsertEmpresa(Empresa empresa);
        Task UpdateEmpresa(Empresa empresa);

    }
}
