using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface ILicenciaPersistencia
    {
        Task<List<Licencia>> GetLicenciaListAsync();
        Task<Licencia> GetLicenciaByIdAsync(int idLicencia);
        Task InsertLicencia(Licencia licencia);
        Task UpdateLicencia(Licencia licencia);

    }
}
