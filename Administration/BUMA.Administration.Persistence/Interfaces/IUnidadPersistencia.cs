using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IUnidadPersistencia
    {
        Task<List<Unidad>> GetUnidadListAsync();
        Task<Unidad> GetUnidadByIdAsync(int idUnidad);
        Task InsertUnidad(Unidad unidad);
        Task UpdateUnidad(Unidad unidad);
    }
}
