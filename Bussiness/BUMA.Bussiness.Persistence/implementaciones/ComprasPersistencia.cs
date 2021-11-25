using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class ComprasPersistencia
    {
        public async Task<List<Compras>> GetComprasListAsync()
        {
            var compras = new List<Compras>();
            return compras;
        }
        public async Task<Compras> GetComprasByIdAsync(int idCompras)
        {
            var compras = new Compras();
            return compras;
        }
        public async Task InsertCompras(Compras compras)
        {
            compras = new Compras();
        }
        public async Task UpdateCompras(Compras compras)
        {
            compras = new Compras();
        }
    }
}
