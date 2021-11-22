using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class UnidadPersistencia : IUnidadPersistencia
    {
        public async Task<List<Unidad>> GetUnidadListAsync()
        {
            var unidad = new List<Unidad>();
            return unidad;
        }
        public async Task<Unidad> GetUnidadByIdAsync(int idUnidad)
        {
            var unidad = new Unidad();
            return unidad;
        }
        public async Task InsertUnidad(Unidad unidad)
        {
            unidad = new Unidad();
        }
        public async Task UpdateUnidad(Unidad unidad)
        {
            unidad = new Unidad();
        }
    }
}
