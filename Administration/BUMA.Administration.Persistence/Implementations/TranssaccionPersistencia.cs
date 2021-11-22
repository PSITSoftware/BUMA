using BUMA.Administration.Persistence.Interfaces;
using BUMA.Domain.DTO.Administration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Administration.Persistence.Implementations
{
   public  class TranssaccionPersistencia : ITranssacionPersistencia
    {
        public async Task<List<Trasaccion>> GetTransaccionListAsync()
        {
            var transaccion = new List<Trasaccion>();
            return transaccion;
        }
        public async Task<Trasaccion> GetTransaccionByIdAsync(int idTransaccion)
        {
            var transaccion = new Trasaccion();
            return transaccion;
        }
        public async Task InsertTransaccion(Trasaccion transaccion)
        {
            transaccion = new Trasaccion();
        }
        public async Task UpdateTransaccion(Trasaccion transaccion)
        {
            transaccion = new Trasaccion();
        }
    }
}
