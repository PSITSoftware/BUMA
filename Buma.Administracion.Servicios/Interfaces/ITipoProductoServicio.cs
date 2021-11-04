﻿// ==================================================================================
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
// 0.1	30/10/2021	    Edwn Andres Florez	    Desarrollo Inicial



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buma.dominio.DTO.Administracion;

namespace Buma.Administracion.servicios.Interfaces
{
    public interface ITipoProductoServicio
    {
        public Task<List<TipoProducto>> GetTipoProductoListAsync();

        public Task<TipoProducto> GetTipoProductoByIdAsync(int idTipoProducto);
        public Task InsertTipoProducto(TipoProducto tipoproducto);
        public Task UpdateTipoProducto(TipoProducto tipoproducto);
    }
}
