using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IInsumoPersistencia
    {
        Task<List<Insumo>> GetInsumoListAsync();
        Task<Insumo> GetInsumoByIdAsync(int idInsumo);
        Task InsertInsumo(Insumo insumo);
        Task UpdateInsumo(Insumo insumo);
    }
}
