using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.interfaces
{
    public interface IComprasPersistencia
    {
        Task<List<Compras>> GetComprasListAsync();
        Task<Compras> GetComprasByIdAsync(int idCompras);
        Task InsertCompras(Compras Compras);
        Task UpdateCompras(Compras Compras);
    }
}
