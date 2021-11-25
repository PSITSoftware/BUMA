using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class InventarioPersistencia : IInventarioPersistencia
    {
        public async Task<List<Inventario>> GetInventarioListAsync()
        {
            var inventario = new List<Inventario>();
            return inventario;
        }
        public async Task<Inventario> GetInventarioByIdAsync(int idInventario)
        {
            var inventario = new Inventario();
            return inventario;
        }
        public async Task InsertInventario(Inventario inventario)
        {
            inventario = new Inventario();
        }
        public async Task UpdateInventario(Inventario inventario)
        {
            inventario = new Inventario();
        }
    }
}
