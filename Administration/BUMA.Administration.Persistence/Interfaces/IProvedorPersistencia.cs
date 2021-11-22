using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IProvedorPersistencia
    {
        Task<List<Provedor>> GetProvedorListAsync();
        Task<Provedor> GetProvedorByIdAsync(int idprovedor);
        Task InsertProvedor(Provedor provedor);
        Task UpdateProvedor(Provedor provedor);
    }
}
