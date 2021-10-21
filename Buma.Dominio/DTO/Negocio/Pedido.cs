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
    public class Pedido
    {
        public int idpedido
        {
            get;set;
        }
        public int numeropedido
        {
            get;set;
        }
        public DateTime fechapedido
        {
            get;set;
        }
        public int idusuario
        {
            get;set;
        }
        public int idubicacion
        {
            get;set;
        }
        public int estado
        {
            get;set;
        }
        public int idempresa
        {
            get;set;
        }

    }
}
