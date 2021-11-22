using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class TipoEmpresaPersistencia : ITipoEmpresaPersistencia
    {
        public async Task<List<TipoEmpresa>> GetTipoEmpresaListAsync()
        {
            var tipoempresa = new List<TipoEmpresa>();
            return tipoempresa;
        }
        public async Task<TipoEmpresa> GetTipoEmpresaByIdAsync(int idTipoEmpresa)
        {
            var tipoempresa = new TipoEmpresa();
            return tipoempresa;
        }
        public async Task InsertTipoEmpresa(TipoEmpresa tipoempresa)
        {
            tipoempresa = new TipoEmpresa();
        }
        public async Task UpdateTipoEmpresa(TipoEmpresa tipoempresa)
        {
            tipoempresa = new TipoEmpresa();
        }
    }
}
