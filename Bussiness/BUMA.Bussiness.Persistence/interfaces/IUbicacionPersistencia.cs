using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IUbicacionPersistencia
    {
        Task<List<Ubicacion>> GetUbicacionListAsync();
        Task<Ubicacion> GetUbicacionByIdAsync(int idUbicacion);
        Task InsertUbicacion(Ubicacion ubicacion);
        Task UpdateUbicacion(Ubicacion ubicacion);
    }
}
