// ==================================================================================
// Desarrollado Por	    : Edwin Andres Florez
// Fecha de Creación	: 19/10/2021
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
     public class Compras
    {
        public int idCompras
        {
            get;set;
        }
        public int idProvedor
        {
            get;set;
        }
        public int numerocompra
        {
            get;set;
        }
        public DateTime fechaCompra
        {
            get;set;
        }
        public int Toltal
        {
            get;set;
        }
        public int Estado
        {
            get;set;
        }
        public int idEmpresa
        {
            get;set;
        }
    }
}
