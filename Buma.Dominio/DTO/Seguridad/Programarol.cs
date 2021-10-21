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

namespace Buma.Dominio.DTO.Seguridad
{
    public class Programarol
    {  
         public int idProgramarol
         {
             get; set;
         }
         public int idPrograma
         {
             get; set;
         }
         public int idRol
         {
             get; set;
         }
         public string Usuariocrea
         {
            get; set;
         }
         public DateTime fechacreacion
         {
            get; set;
         }
        
    }
}
