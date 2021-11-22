using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class ProductoPersistencia
    {
        public async Task<List<producto>> GetProductoListAsync()
        {
            var producto = new List<producto>();
            return producto;
        }
        public async Task<producto> GetProductoByIdAsync(int idProvedor)
        {
            var producto = new producto();
            return producto;
        }
        public async Task InsertProducto(producto producto)
        {
            producto = new producto();
        }
        public async Task UpdateProducto(producto producto)
        {
            producto = new producto();
        }
    }
}
