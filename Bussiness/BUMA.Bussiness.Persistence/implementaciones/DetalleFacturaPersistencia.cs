// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 23/11/2021
// Producto o sistema	: BUMA
// Empresa	: PSIT S.A.S
// Proyecto	: BUMA
// Cliente	: todos
// ==================================================================================
// Versión	Descripción
// 1.0.0.0	<Descripción del archivo>
//
// ==================================================================================
// HISTORIAL DE CAMBIOS:
// =================================================================================
// Ver.	Fecha	        Autor	                Descripción
// ---	-------------	----------------------	-----------------------------------
// 0.1	23/11/2021	    Edwn Andres Florez	    Desarrollo Inicial
using BUMA.Bussiness.Persistence.interfaces;
using BUMA.Domain.DTO.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BUMA.Bussiness.Persistence.implementaciones
{
    public class DetalleFacturaPersistencia : IDetalleFacturaPersistencia
    {
        public async Task<List<Detallefactura>> GetDetallefacturaListAsync()
        {
            var detallefactura = new List<Detallefactura>();
            return detallefactura;
        }
        public async Task<Detallefactura> GetDetallefacturaByIdAsync(int idDetallefactura)
        {
            var detallefactura = new Detallefactura();
            return detallefactura;
        }
        public async Task InsertDetallefactura(Detallefactura detallefactura)
        {
            detallefactura = new Detallefactura();
        }
        public async Task UpdateDetallefactura(Detallefactura detallefactura)
        {
            detallefactura = new Detallefactura();
        }
    }
}
