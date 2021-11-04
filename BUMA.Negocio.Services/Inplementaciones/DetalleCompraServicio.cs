// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 27/10/2021
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
// 0.1	27/10/2021	    Edwn Andres Florez	    Desarrollo Inicial


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Negocio;
using buma.negocio.servicios.Interfaces;


namespace buma.negocio.servicios.Inplementaciones
{
    public class DetalleCompraServicio :IDetalleCompraServicio
    {
        public async Task<List<Detallecompra>> GetDetallecompraListAsync()
        {
            var detallecompra = new List<Detallecompra>();
            return detallecompra;
        }

        public async Task<Detallecompra> GetDetallecompraByIdAsync(int idDetallecompra)
        {
            var detallecompra = new Detallecompra();
            return detallecompra;
        }
        public async Task InsertDetallecompra(Detallecompra detallecompra)
        {
            detallecompra = new Detallecompra();
        }
        public async Task UpdateDetallecompra(Detallecompra detallecompra)
        {
            detallecompra = new Detallecompra();
        }

    }
}
