﻿// ==================================================================================
// Desarrollado Por	    : Edwin Andres Florez
// Fecha de Creación	: 20/10/2021
// Producto o sistema	: PIDT
// Empresa	: PSIT S.A.S
// Proyecto	: BUMA
// Cliente	: todos
// ==================================================================================
// Versión	Descripción
// 1.0.0.0	<Descripción del archivo>
//
// ==============================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buma.Dominio.DTO.Administracion
{
    class Tipodocumento
    {
        public int idtipodocumento
        {
            get;set;
        }
        public string codigoDocumento
        {
            get;set;
        }
        public string nomTipoDocumento
        {
            get;set;
        }
    }
}
