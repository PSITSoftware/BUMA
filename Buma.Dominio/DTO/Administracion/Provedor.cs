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

namespace buma.dominio.DTO.Administracion
{
    public class Provedor
    {
        public int idprovedor
        {
            get;set;
        }
        public string nit
        {
            get;set;
        }
        public string razonsocial
        {
            get; set;
        }
        public string representantelegal
        {
            get; set;
        }
        public int idtipodocumento
        {
            get;set;
        }
        public string documento
        {
            get;set;
        }
        public string numerocontacto
        {
            get;set;
        }
        public string regimen
        {
            get;set;
        }

    }
}
