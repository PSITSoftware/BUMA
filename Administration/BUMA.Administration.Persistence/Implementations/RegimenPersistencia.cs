using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class RegimenPersistencia : IRegimenPersistencia
    {
        public async Task<List<Regimen>> GetRegimenListAsync()
        {
            var regimen = new List<Regimen>();
            return regimen;
        }
        public async Task<Regimen> GetRegimenByIdAsync(int idRegimen)
        {
            var regimen = new Regimen();
            return regimen;
        }
        public async Task InsertRegimen(Regimen regimen)
        {
            regimen = new Regimen();
        }
        public async Task UpdateRegimen(Regimen regimen)
        {
            regimen = new Regimen();
        }

    }
}
