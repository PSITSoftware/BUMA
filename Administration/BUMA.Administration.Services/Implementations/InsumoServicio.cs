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
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;

namespace BUMA.Administration.Services.Implementations
{
    public class InsumoServicio
    {
        public async Task<List<Insumo>> GetInsumoListAsync()
        {
            var insumo = new List<Insumo>();
            return insumo;
        }

        public async Task<Insumo> GetInsumoByIdAsync(int idInsumo)
        {
            var insumo = new Insumo();
            return insumo;
        }
        public async Task InsertInsumo(Insumo insumo)
        {
            insumo = new Insumo();

        }
        public async Task UpdateInsumo(Insumo insumo)
        {
            insumo = new Insumo();
        }
    }
}
