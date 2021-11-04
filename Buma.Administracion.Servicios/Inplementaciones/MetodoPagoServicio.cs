// // ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 28/10/2021
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
// 0.1	28/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Administracion;
using Buma.Administracion.servicios.Interfaces;

namespace Buma.Administracion.servicios.Inplementaciones
{
    public class MetodoPagoServicio :IMetodoPagoServicio
    {
        public async Task<List<Metodopago>> GetMetodoPagoListAsync()
        {
            var metodopago = new List<Metodopago>();
            return metodopago;
        }

        public async Task<Metodopago> GetMetodoPagoByIdAsync(int idMetodoPago)
        {
            var MetodoPago = new Metodopago();
            return MetodoPago;
        }
        public async Task InsertMetodopago(Metodopago metodopago)
        {
            metodopago = new Metodopago();

        }
        public async Task UpdateMetodopago(Metodopago metodopago)
        {
            metodopago = new Metodopago();
        }

    }
}
