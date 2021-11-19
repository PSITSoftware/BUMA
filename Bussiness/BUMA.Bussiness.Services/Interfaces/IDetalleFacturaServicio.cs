// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 26/10/2021
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
// 0.1	26/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Bussiness;

namespace BUMA.Bussiness.Services.Interfaces
{
     public interface IDetalleFacturaServicio
    {
        Task<List<Detallefactura>> GetDetallefacturaListAsync();

        Task<Detallefactura> GetDetallefacturaByIdAsync(int idDetallefactura);
        Task InsertDetallefactura(Detallefactura detallefactura);
        Task UpdateDetallefactura(Detallefactura detallefactura);
    }
}
