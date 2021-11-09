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
    public class ClienteServicio :IClienteServicio
    {
        public async Task<List<Cliente>> GetClienteListAsync()
        {
            var cliente = new List<Cliente>();
            return cliente;
        }

        public async Task<Cliente> GetClienteByIdAsync(int iCliente)
        {
            var cliente = new Cliente();
            return cliente;
        }
        public async Task InsertCliente(Cliente cliente)
        {
            cliente = new Cliente();
        }
        public async Task UpdateCliente(Cliente cliente)
        {
            cliente = new Cliente();
        }

    }
}
