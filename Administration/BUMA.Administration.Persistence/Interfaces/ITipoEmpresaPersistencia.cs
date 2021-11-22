using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface ITipoEmpresaPersistencia
    {
        Task<List<TipoEmpresa>> GetTipoEmpresaListAsync();
        Task<TipoEmpresa> GetTipoEmpresaByIdAsync(int idTipoEmpresa);
        Task InsertTipoEmpresa(TipoEmpresa tipoempresa);
        Task UpdateTipoEmpresa(TipoEmpresa tipoempresa);
    }
}
