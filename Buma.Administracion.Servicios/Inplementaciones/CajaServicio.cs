// ==================================================================================
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
   public  class CajaServicio :ICajaServicio
    {
        public async Task<List<Caja>> GetCajaListAsync()
        {
            var caja = new List<Caja>();
            return caja;
        }

        public async Task<Caja> GetCajaByIdAsync(int idCaja)
        {
            var caja = new Caja();
            return caja;
        }
        public async Task InsertCaja(Caja caja)
        {
            caja = new Caja();
        }
        public async Task UpdateCaja(Caja caja)
        {
            caja = new Caja();
        }
    }
}
