using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface ITipoDocumentoPersistencia
    {
        Task<List<Tipodocumento>> GetTipoDocumentoListAsync();
        Task<Tipodocumento> GetTipoDocumentoByIdAsync(int idTipodocumento);
        Task InsertTipoDocumento(Tipodocumento tipodocumento);
        Task UpdateTipoDocumento(Tipodocumento tipodocumento);
    }
}
