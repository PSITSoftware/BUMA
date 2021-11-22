using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface ISubUbicacionPersistencia
    {
        Task<List<Sububicacion>> GetSububicacionListAsync();
        Task<Sububicacion> GetSububicacionByIdAsync(int idSububicacion);
        Task InsertSububicacion(Sububicacion sububicacion);
        Task UpdateSububicacion(Sububicacion sububicacion);
    }
}
