using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class ProgramaPersistencia : IProgramaPersistencia
    {
        public async Task<List<Programa>> GetProgramaListAsync()
        {
            var programa = new List<Programa>();
            return programa;
        }
        public async Task<Programa> GetProgramaByIdAsync(int idPrograma)
        {
            var programa = new Programa();
            return programa;
        }
        public async Task InsertPrograma(Programa programa)
        {
            programa = new Programa();
        }
        public async Task UpdatePrograma(Programa programa)
        {
            programa = new Programa();
        }
    }
}
