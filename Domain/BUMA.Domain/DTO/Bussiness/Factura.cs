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
// ==============================================================================using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUMA.Domain.DTO.Bussiness
{
     public class Factura
    {
        public int idfactura
        {
            get;set;
        }
        public int numerofactura
        {
            get;set;
        }
        public int idcliente
        {
            get;set;
        }
        public string fechaventa
        {
            get;set;
        }
        public int idcaja
        {
            get;set;
        }
        public int total
        {
            get;set;
        }
        public int idmetodopago
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
