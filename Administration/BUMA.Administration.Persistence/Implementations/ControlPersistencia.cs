using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
    public class ControlPersistencia : IControlPersistencia
    {
        public async Task<List<Control>> GetControlListAsync()
        {
            var control = new List<Control>();
            return control;
        }
        public async Task<Control> GetControlByIdAsync(int idControl)
        {
            var control = new Control();
            return control;
        }
        public async Task InsertControl(Control control)
        {
            control = new Control();
        }
        public async Task UpdateControl(Control control)
        {
            control = new Control();
        }
    }
}
