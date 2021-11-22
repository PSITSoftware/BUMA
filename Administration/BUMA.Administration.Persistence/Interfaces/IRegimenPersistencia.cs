using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IRegimenPersistencia
    {
        Task<List<Regimen>> GetRegimenListAsync();
        Task<Regimen> GetRegimenByIdAsync(int idRegimen);
        Task InsertRegimen(Regimen regimen);
        Task UpdateRegimen(Regimen regimen);
    }
}
