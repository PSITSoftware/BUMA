﻿// ==================================================================================
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
namespace buma.negocio.servicios.Interfaces
{
    public interface IFacturaServicio
    {
        public Task<List<Factura>> GetFacturaListAsync();

        public Task<Factura> GetFacturaByIdAsync(int idFactura);
        public Task InsertFactura(Factura factura);
        public Task UpdateFactura(Factura factura);
    }
}
