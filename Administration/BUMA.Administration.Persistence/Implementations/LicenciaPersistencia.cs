using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class LicenciaPersistencia : ILicenciaPersistencia
    {
        public async Task<List<Licencia>> GetLicenciaListAsync()
        {
            var licencia = new List<Licencia>();
            return licencia;
        }
        public async Task<Licencia> GetLicenciaByIdAsync(int idLicencia)
        {
            var licencia = new Licencia();
            return licencia;
        }
        public async Task InsertLicencia(Licencia licencia)
        {
            licencia = new Licencia();
        }
        public async Task UpdateLicencia(Licencia licencia)
        {
            licencia = new Licencia();
        }
    }
}
