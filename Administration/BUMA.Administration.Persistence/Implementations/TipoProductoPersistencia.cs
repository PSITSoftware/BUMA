using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class TipoProductoPersistencia : ITipoProductoPersistencia
    {
        public async Task<List<TipoProducto>> GetTipoProductoListAsync()
        {
            var tipoproducto = new List<TipoProducto>();
            return tipoproducto;
        }
        public async Task<TipoProducto> GetTipoProductoByIdAsync(int idTipoproducto)
        {
            var Tipoproducto = new TipoProducto();
            return Tipoproducto;
        }
        public async Task InsertTipoProducto(TipoProducto Tipoproducto)
        {
            Tipoproducto = new TipoProducto();
        }
        public async Task UpdateTipoProducto(TipoProducto Tipoproducto)
        {
            Tipoproducto = new TipoProducto();
        }
    }
}
