using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class SucursalPersistencia : ISucursalPersistencia
    {
        
            public async Task<List<Sucursal>> GetSucursalListAsync()
            {
                var sucursal = new List<Sucursal>();
                return sucursal;
            }
            public async Task<Sucursal> GetSucursalByIdAsync(int idSucursal)
            {
                var sucursal = new Sucursal();
                return sucursal;
            }
            public async Task InsertSucursal(Sucursal sucursal)
            {
            sucursal = new Sucursal();
            }
            public async Task UpdateSucursal(Sucursal sucursal)
            {
            sucursal = new Sucursal();
            }
    }
}
