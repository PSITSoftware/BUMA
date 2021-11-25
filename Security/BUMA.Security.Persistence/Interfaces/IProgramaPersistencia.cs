using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BUMA.Security.Persistence.Interfaces
{
    public interface IProgramaPersistencia
    {
        Task<List<Programa>> GetProgramaListAsync();
        Task<Programa> GetProgramaByIdAsync(int idPrograma);
        Task InsertPrograma(Programa programa);
        Task UpdatePrograma(Programa Programa);
    }
}
