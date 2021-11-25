using BUMA.Security.Persistence.Interfaces;
using BUMA.Domain.DTO.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Security.Persistence.Implementaciones
{
    public class ModuloPersistencia : IModuloPersistencia
    {
        public async Task<List<Modulo>> GetModuloListAsync()
        {
            var modulo = new List<Modulo>();
            return modulo;
        }
        public async Task<Modulo> GetModuloByIdAsync(int idModulo)
        {
            var modulo = new Modulo();
            return modulo;
        }
        public async Task InsertModulo(Modulo modulo)
        {
            modulo = new Modulo();
        }
        public async Task UpdateModulo(Modulo modulo)
        {
            modulo = new Modulo();
        }
    }
}
