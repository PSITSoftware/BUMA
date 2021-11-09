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

namespace BUMA.Domain.DTO.Bussiness
{
    public class Detallecompra
    {
        public int iddetallecompra
        {
            get;set;
        }
        public int idinsumo
        {
            get;set;
        }
        public int idunidad
        {
            get;set;
        }
        public int valor
        {
            get;set;
        }
        public int cantidad
        {
            get;set;
        }
        public int idcompra
        {
            get;set;
        }
    }
}
