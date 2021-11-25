using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class FacturaPersistencia :IFacturaPersistencia
    {
        public async Task<List<Factura>> GetFacturaListAsync()
        {
            var factura = new List<Factura>();
            return factura;
        }
        public async Task<Factura> GetFacturaByIdAsync(int idFactura)
        {
            var factura = new Factura();
            return factura;
        }
        public async Task InsertFactura(Factura factura)
        {
            factura = new Factura();
        }
        public async Task UpdateFactura(Factura factura)
        {
            factura = new Factura();
        }
    }
}
