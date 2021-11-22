using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class MetodoPagoaPersistencia : IMetodoPagoPersistencia
    {
        public async Task<List<Metodopago>> GetMetodopagoListAsync()
        {
            var metodopago = new List<Metodopago>();
            return metodopago;
        }
        public async Task<Metodopago> GetMetodopagoByIdAsync(int idMetodopago)
        {
            var metodopago = new Metodopago();
            return metodopago;
        }
        public async Task InsertMetodopago(Metodopago metodopago)
        {
            metodopago = new Metodopago();
        }
        public async Task UpdateMetodopago(Metodopago metodopago)
        {
            metodopago = new Metodopago();
        }
    }
}
