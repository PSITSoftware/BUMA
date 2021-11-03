// ==================================================================================
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

namespace Buma.Dominio.DTO.Negocio
{
     public class Detallepedido
    {
        public int iddetallepedido
        {
            get;set;
        }
        public int idproducto
        {
            get;set;
        }
        public int idpedido
        {
            get;set;
        }
        public int cantidad
        {
            get;set;
        }
    }
}
