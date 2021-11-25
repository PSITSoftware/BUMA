using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class ProgramaRolPersistencia : IProgramaRolPersistencia
    {
        public async Task<List<Programarol>> GetProgramarolListAsync()
        {
            var programarol = new List<Programarol>();
            return programarol;
        }
        public async Task<Programarol> GetProgramarolByIdAsync(int idProgramarol)
        {
            var programarol = new Programarol();
            return programarol;
        }
        public async Task InsertProgramarol(Programarol programarol)
        {
            programarol = new Programarol();
        }
        public async Task UpdateProgramarol(Programarol programarol)
        {
            programarol = new Programarol();
        }
    }
}
