using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
   public interface ISucursalPersistencia
    {
        Task<List<Sucursal>> GetSucursalListAsync();
        Task<Sucursal> GetSucursalByIdAsync(int idSucursal);
        Task InsertSucursal(Sucursal sucursal);
        Task UpdateSucursal(Sucursal sucursal);
    }
}
