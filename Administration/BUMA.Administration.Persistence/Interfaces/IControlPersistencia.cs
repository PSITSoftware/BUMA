using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Interfaces
{
    public interface IControlPersistencia
    {

        Task<List<Control>> GetControlListAsync();
        Task<Control> GetControlByIdAsync(int idControl);
        Task InsertControl(Control control);
        Task UpdateControl(Control control);    

    }
}
