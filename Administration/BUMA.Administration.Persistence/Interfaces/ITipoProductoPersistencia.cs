using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface ITipoProductoPersistencia
    {
        Task<List<TipoProducto>> GetTipoProductoListAsync();
        Task<TipoProducto> GetTipoProductoByIdAsync(int idTipoProducto);
        Task InsertTipoProducto(TipoProducto tipoproducto);
        Task UpdateTipoProducto(TipoProducto tipoproducto);
    }
}
