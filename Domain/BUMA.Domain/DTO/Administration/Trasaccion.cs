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

namespace BUMA.Domain.DTO.Administration
{
    public class Trasaccion
    {
        public int idtransaccion
        {
            get;set;
        }
        public int estado
        {
            get;set;
        }
        public string franquicia
        {
            get;set;
        }
        public string descripccion
        {
            get;set;
        }
    }
}
