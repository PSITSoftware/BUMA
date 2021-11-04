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

namespace buma.dominio.DTO.Negocio
{
     public class Inventario
    {
        public int idinventario
        {
            get;set;
        }
        public int idproducto
        {
            get;set;
        }
        public DateTime fechaingreso
        {
            get;set;
        }
        public DateTime fechavencimiento
        {
            get;set;
        }
        public int catidad
        {
            get;set;
        }
        public string codigodebarras
        {
            get;set;
        }
        public int valorneto
        {
            get;set;
        }
        public int valortotal
        {
            get;set;
        }
        public int peso
        {
            get;set;
        }
        public int idempresa
        {
            get;set;
        }
    }
}
