using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class SubUbicacionPersistencia : ISubUbicacionPersistencia
    {
        public async Task<List<Sububicacion>> GetSububicacionListAsync()
        {
            var sububicacion = new List<Sububicacion>();
            return sububicacion;
        }
        public async Task<Sububicacion> GetSububicacionByIdAsync(int idSububicacion)
        {
            var Sububicacion = new Sububicacion();
            return Sububicacion;
        }
        public async Task InsertSububicacion(Sububicacion sububicacion)
        {
            sububicacion = new Sububicacion();
        }
        public async Task UpdateSububicacion(Sububicacion sububicacion)
        {
            sububicacion = new Sububicacion();
        }
    }
}
