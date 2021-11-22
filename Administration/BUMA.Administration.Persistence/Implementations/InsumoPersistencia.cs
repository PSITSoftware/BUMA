using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class InsumoPersistencia : IInsumoPersistencia
    {
        public async Task<List<Insumo>> GetInsumoListAsync()
        {
            var insumo = new List<Insumo>();
            return insumo;
        }
        public async Task<Insumo> GetInsumoByIdAsync(int idInsumo)
        {
            var insumo = new Insumo();
            return insumo;
        }
        public async Task InsertInsumo(Insumo insumo)
        {
            insumo = new Insumo();
        }
        public async Task UpdateInsumo(Insumo insumo)
        {
            insumo = new Insumo();
        }
    }
}
