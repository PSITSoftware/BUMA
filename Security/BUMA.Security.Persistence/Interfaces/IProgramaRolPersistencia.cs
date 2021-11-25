using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Interfaces
{
    public interface IProgramaRolPersistencia
    {
        Task<List<Programarol>> GetProgramarolListAsync();
        Task<Programarol> GetProgramarolByIdAsync(int idProgramarol);
        Task InsertProgramarol(Programarol programarol);
        Task UpdateProgramarol(Programarol programarol);
    }
}
