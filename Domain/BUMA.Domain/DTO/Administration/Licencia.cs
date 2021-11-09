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
     public class Licencia
    {
        public int idlicencia
        {
            get;set;
        }
        public string nombre
        {
            get;set;
        }
        public string descripcion
        {
            get;set;
        }
        public int valor
        {
            get;set;
        }
        public int periodo
        {
            get; set;
        }
        public int puntos
        {
            get;set;
        }
    }
}
