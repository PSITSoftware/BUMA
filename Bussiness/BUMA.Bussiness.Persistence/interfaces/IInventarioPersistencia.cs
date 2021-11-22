using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IInventarioPersistencia
    {
        Task<List<Inventario>> GetInventarioListAsync();
        Task<Inventario> GetInventarioByIdAsync(int idInventario);
        Task InsertInventario(Inventario inventario);
        Task UpdateInventario(Inventario inventario);
    }
}
