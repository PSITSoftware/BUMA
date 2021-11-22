using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IProductoPeristencia
    {
        Task<List<producto>> GetProductoListAsync();
        Task<producto> GetProductoByIdAsync(int idproducto);
        Task InsertProducto(producto producto);
        Task UpdateProducto(producto producto);
    }
}
