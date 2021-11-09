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
using BUMA.Domain.DTO.Bussiness;
using BUMA.Bussiness.Services.Interfaces;

namespace BUMA.Bussiness.Services.Implementations
{
    public class ComprasServicio
    {
        public async Task<List<Compras>> GetComprasListAsync()
        {
            var compras = new List<Compras>();
            return compras;
        }

        public async Task<Compras> GetComprasByIdAsync(int idUsuario)
        {
            var compras = new Compras();
            return compras;
        }
        public async Task InsertCompras(Compras compras)
        {
            compras = new Compras();

        }
        public async Task UpdateCompras(Compras compras)
        {
            compras = new Compras();
        }
    }
}
