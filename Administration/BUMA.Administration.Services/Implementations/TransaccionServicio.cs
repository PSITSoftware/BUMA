// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 30/10/2021
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
// 0.1	25/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUMA.Domain.DTO.Administration;
using BUMA.Administration.Services.Interfaces;

namespace BUMA.Administration.Services.Implementations
{
    public class TransaccionServicio : ITransaccionServicio
    {
        public async Task<List<Trasaccion>> GetTransaccionListAsync()
        {
            var regimen = new List<Trasaccion>();
            return regimen;
        }

        public async Task<Trasaccion> GetTransaccionByIdAsync(int idTransaccion)
        {
            var trasaccion = new Trasaccion();
            return trasaccion;
        }
        public async Task InsertTrasaccion(Trasaccion transaccion)
        {
            transaccion = new Trasaccion();

        }
        public async Task UpdateTrasaccion(Trasaccion transaccion)
        {
            transaccion = new Trasaccion();
        }
    }
}
