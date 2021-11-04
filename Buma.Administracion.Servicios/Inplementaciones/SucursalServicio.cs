// ==================================================================================
// Desarrollado Por	    : Edwn Andres Florez
// Fecha de Creación	: 29/10/2021
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
// 0.1	29/10/2021	    Edwn Andres Florez	    Desarrollo Inicial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Administracion;
using Buma.Administracion.servicios.Interfaces;

namespace Buma.Administracion.servicios.Inplementaciones
{
    public class SucursalServicio :ISucursalServicio
    {
        public async Task<List<Sucursal>> GetSucursalListAsync()
        {
            var sucursal = new List<Sucursal>();
            return sucursal;
        }

        public async Task<Sucursal> GetSucursalByIdAsync(int idSucursal)
        {
            var sucursal = new Sucursal();
            return sucursal;
        }
        public async Task InsertSucursal(Sucursal sucursal)
        {
            sucursal = new Sucursal();

        }
        public async Task UpdateSucursal(Sucursal sucursal)
        {
            sucursal = new Sucursal();
        }
    }
}
